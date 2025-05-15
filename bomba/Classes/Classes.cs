using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Bomba
    {
        public bool? Estado()
        {
            bool sensorA = Caixa.SensorA, sensorB = Caixa.SensorB, SensorC = Reservatorio.SensorB;
            if (SensorC == false)
            {
                return false; 
            }
            
                if (sensorA == true && sensorB == true || sensorA == false && sensorB == true)
                {
                    return false;
                }
                else if (sensorA == false && sensorB == false)
                {
                    return true;
                }
                else
                {
                    return null;
                }
        }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public class Torneira
    {
        public bool? Estado()
        {
            bool sensorA = Reservatorio.SensorA;
            bool sensorB = Reservatorio.SensorB;
            if (sensorA == true && sensorB == true || sensorA == false && sensorB == true)
            {
                return false;
            }
            else if (sensorA == false && sensorB == false)
            {
                return true;
            }
            else
            {
                return null;
            }
        }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public class Reservatorio
    {
        public static double NivelAtual { get; set; }

        public static bool SensorB => NivelAtual < 30;
        public static bool SensorA => NivelAtual > 80;
        public static double Saida => Bomba.Vazao;
        public static double Entrada => Torneira.Vazao;
    }
    public class Caixa
    {
        public static double NivelAtual { get; set; }
        public static bool SensorB => NivelAtual < 30;
        public static bool SensorA => NivelAtual > 80;
        public double Saida { get; set; }
        public double Entrada => Reservatorio.Saida;
    }
    
}
