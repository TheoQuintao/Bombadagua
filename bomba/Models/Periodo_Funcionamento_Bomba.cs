namespace Bomba_Name.Models
{
    public class Periodo_Funcionamento_Bomba
    {
        public int ID { get; set; }
        public DateTime Data_Hora_Inicio { get; set; }
        public DateTime Data_Hora_Fim { get; set; }
        // Posteriomente corrigir e colocar o database para pegar o tempo atual e fazer o C# pegar o tempo do MySQL
        public Bomba Bomba_ID {get; set;}
        
    }
}