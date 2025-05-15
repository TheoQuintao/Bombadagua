using System.Security.Cryptography;

namespace Classes
{
    public class Bomba
    {
        public bool Estado { get; set; }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public class Torneira
    {
        public bool Estado { get; set; }
        public static double Vazao { get; set; }
        public double TempoFuncionamento { get; set; }
    }
    public static class Reservatorio
    {
        public static double Capacidade { get; set; }
        public static double NivelAtual { get; set; }
        public static double Saida => Bomba.Vazao;
        public static double Entrada => Torneira.Vazao;
    }
    public class Caixa
    {
        public double Capacidade { get; set; }
        public double NivelAtual { get; set; }
        public double Saida { get; set; }
        public double Entrada => Reservatorio.Saida;
    }
    
}
