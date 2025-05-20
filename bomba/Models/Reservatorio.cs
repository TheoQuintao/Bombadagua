namespace Bomba_Name.Models
{
    public class Teservatorio
    {
        public int ID { get; set; }
        public int Capacidade { get; set; }
        public bool Sensor_SUP { get; set; }
        public bool Sensor_INF { get; set; }
        public Torneira Torneira_ID { get; set; }
        public string? Ind_Reservatorio { get; set; }
        public Caixa Caixa_ID { get; set; }//Futuramente mudar para lista
        
    }
}