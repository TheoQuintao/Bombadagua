namespace Bomba.Models
{
    public class Media_Temp
    {
        public int ID { get; set; }
        public int Media_Fun_Bomba { get; set; }
        public int Media_Fun_Torneira { get; set; }//depois de adcionar o Temp na bomba e torneira, adicionar uma meida aqui
        public Periodo_Funcionamento_Torneira Periodo_Funcionamento_Torneira_ID { get; set; }
        public Periodo_Funcionamento_Bomba Periodo_Funcionamento_Bomba_ID { get; set; }
    }
}