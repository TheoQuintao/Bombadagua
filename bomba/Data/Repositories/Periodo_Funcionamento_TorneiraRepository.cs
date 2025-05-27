using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class Periodo_Funcionamento_TorneiraRepository
    {
        public void AddPeriodo_Funcionamento_Torneira(Periodo_Funcionamento_Torneira PFT)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Periodo_Funcionamento_Torneira 
                     (ID, Data_Hora_Inicio, Data_Hora_Fim,  Torneira_ID) 
                     VALUES (@ID, @Data_Hora_Inicio, @Data_Hora_Fim,  @Torneira_ID)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", PFT.ID);
                    cmd.Parameters.AddWithValue("@Data_Hora_Inicio", PFT.Data_Hora_Inicio);
                    cmd.Parameters.AddWithValue("@Data_Hora_Fim", PFT.Data_Hora_Fim);
                    cmd.Parameters.AddWithValue("@Torneira_ID", PFT.Tornerira_ID.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}    