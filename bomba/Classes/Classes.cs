using System.Net;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Bomba_Main
    {
        private static bool bombaLigada = false;
        public static bool? Estado(bool sensorA, bool sensorB)
        {
            // sensorA = Caixa.SensorA (nível > 80)
            // sensorB = Caixa.SensorB (nível > 30)
            // sensorC = não usado aqui
            if (!sensorB) // Nível <= 30, liga a bomba
            {
                bombaLigada = true;
            }
            else if (sensorA) // Nível > 80, desliga a bomba
            {
                bombaLigada = false;
            }
            // Retorna o estado atual da bomba
            return bombaLigada;
        }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public class Torneira
    {
        private static bool torneiraLigada = false;
        public static bool? Estado(bool sensorA, bool sensorB)
        {
            // Controle de histerese:
            // Liga a torneira quando Reservatorio.SensorB (sensorB) for falso (nível <= 30)
            // Só desliga quando Reservatorio.SensorA (sensorA) for verdadeiro (nível > 80)
            if (!sensorB) // Nível <= 30, liga a torneira
            {
                torneiraLigada = true;
            }
            else if (sensorA) // Nível > 80, desliga a torneira
            {
                torneiraLigada = false;
            }
            // Retorna o estado atual da torneira
            return torneiraLigada;
        }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public class Reservatorio
    {
        public static double NivelAtual { get; set; }

        public static bool SensorB => NivelAtual > 30;
        public static bool SensorA => NivelAtual > 80;
        public static double Saida => Bomba_Main.Vazao;
        public static double Entrada => Torneira.Vazao;
    }
    public class Caixa
    {
        public static double NivelAtual { get; set; }
        public static double Saida { get; set; }
        public static bool SensorB => NivelAtual > 30;
        public static bool SensorA => NivelAtual > 80;
        public double Entrada => Reservatorio.Saida;
    }
}
