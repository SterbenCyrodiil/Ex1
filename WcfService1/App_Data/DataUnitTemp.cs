using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Meramente para efeitos de aprendizagem - utilizada data desta forma visto que o objectivo base é aprender a manipular WS
namespace WcfServiceAcademia.Data
{
    public static class DataUnitTemp
    {
        public static List<UnitTemp> UnitTemps
        {
            get
            {
                return new List<UnitTemp>()
                {
                    new UnitTemp{ ID=1, Name="Celsius", Description="Celsius, historically known as centigrade,[1][2] is a scale and unit of measurement for temperature. As an SI derived unit, it is used by most countries in the world. It is named after the Swedish astronomer Anders Celsius (1701–1744), who developed a similar temperature scale. The degree Celsius (°C) can refer to a specific temperature on the Celsius scale as well as a unit to indicate a temperature interval, a difference between two temperatures or an uncertainty. Before being renamed to honour Anders Celsius in 1948, the unit was called centigrade, from the Latin centum, which means 100, and gradus, which means steps."},
                    new UnitTemp {ID = 2, Name="Fahrenheit" , Description="Fahrenheit (symbol °F) is a temperature scale based on one proposed in 1724 by the German physicist Daniel Gabriel Fahrenheit (1686–1736), after whom the scale is named.[1] There exist several accounts of how he originally defined his scale. The lower defining point, 0 degrees, was established as the temperature of a solution of brine made from equal parts of ice and salt. Further limits were established as the melting point of water (32 degrees) and his best estimate of the average human body temperature (96 degrees, about 2-1/2 degrees less than modern measurements).[2] The scale is now usually defined by two fixed points: the temperature at which water freezes into ice is defined as 32 degrees, and the boiling point of water is defined to be 212 degrees, a 180-degree separation, as defined at sea level and standard atmospheric pressure."},
                    new UnitTemp {ID=3, Name="Kelvin", Description="O kelvin (símbolo: K) é o nome da unidade de base do Sistema Internacional de Unidades (SI) para a grandeza temperatura termodinâmica. O kelvin é a fração 1/273,16 da temperatura termodinâmica do ponto triplo da água, ou seja, é definido de tal modo que o ponto triplo da água é exatamente 273,16 K..[1] É uma das sete unidades de base do SI, muito utilizada na Física e Química. É utilizado para medir a temperatura absoluta de um objeto, com zero absoluto sendo 0 K, muitas vezes sendo usado em conjunto com o grau Celsius , que tem a mesma ordem de grandeza."}
                };

            }
        }
    }
}