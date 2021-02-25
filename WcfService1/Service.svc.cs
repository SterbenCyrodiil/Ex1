using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceAcademia
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        List<UnitTemp> units;
        bool initated = false;

        public void iniateUnits()
        {
            units = new List<UnitTemp>();
            UnitTemp kelvin = new UnitTemp() { ID = 1, Name = "Kelvin", Description = "Scientifical temperature scale ranging from absolute coldness to infinite hotness using the Celsius scale" };
            UnitTemp celsius = new UnitTemp(); //I could make this all the same
            celsius.ID = 2;
            celsius.Name = "Celsius";
            celsius.Description = "Day to day scale based on a 0 to 100 between the three states of water.";
            UnitTemp fahrenheit = new UnitTemp();
            fahrenheit.ID = 2;
            fahrenheit.Name = "Fahrenheit";
            fahrenheit.Description = "What in oblivion is this, I think only the US of America uses this scale. Did I even spell it right?";
            units.Add(kelvin);
            units.Add(celsius);
            units.Add(fahrenheit);
            initated = true;
        }

        public double ConvertTemp(int unitFrom, int unitTo, double temperature)
        {
            if (!initated)
                iniateUnits();


            if (unitFrom == 1 && unitTo == 2)
                return temperature - 273;
            if (unitFrom == 1 && unitTo == 3)
                return 9.0/5.0*(temperature - 273) + 32;
            if (unitFrom == 2 && unitTo == 1)
                return temperature + 273;
            if (unitFrom == 2 && unitTo == 3)
                return 9.0 / 5.0*temperature + 32;
            if (unitFrom == 3 && unitTo == 1)
                return 5.0/9.0*(temperature - 32) + 273;
            if (unitFrom == 3 && unitTo == 2)
                return 5.0 / 9.0 * (temperature - 32);
            return 0.0; 
            
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Task<string> GetDataAsync(string value)
        {
            return Task.FromResult(string.Format("You entered: {0}", value));
        }

        public List<UnitTemp> GetTempUnits()
        {
            if (!initated)
                iniateUnits();
            return units; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(Service), new Uri("http://localhost:3000/"));
            ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
            host.Open();
            Console.WriteLine("Service is running");
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
            host.Close();

        }
    }
}
