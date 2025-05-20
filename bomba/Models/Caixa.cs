namespace Bomba_Name.Models
{
    public class Caixa
    {
        public int ID { get; set; }
        public int Capacidade { get; set; }
        public bool Sensor_SUP { get; set; }
        public bool Sensor_INF { get; set; }
        public Bomba Bomba_ID { get; set; }
        public string? Ind_Caixa { get; set;}
        
    }
}