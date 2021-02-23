using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceAcademia
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        string GetData(string value);
        
        Task<string> GetDataAsync(string value);
        [OperationContract]
        List<UnitTemp> GetTempUnits();
        [OperationContract]
        double ConvertTemp(int unitFrom, int unitTo, double temperature);

        // TODO: Add your service operations here
    }


    
}
