namespace Bomba_Name.Models
{
    public class Periodo_Funcionamento_Torneira
    {
        public int ID { get; set; }
        public DateTime Data_Hora_Inicio { get; set; }
        public DateTime Data_Hora_Fim { get; set; }
        // Posteriomente corrigir e colocar o database para pegar o tempo atual e fazer o C# pegar o tempo do MySQL
        public Torneira Tornerira_ID {get; set;}
        
    }
}