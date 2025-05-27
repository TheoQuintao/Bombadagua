using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class Periodo_Funcionamento_BombaRepository
    {
        public void AddPeriodo_Funcionamento_Bomba(Periodo_Funcionamento_Bomba PFB)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Periodo_Funcionamento_Bomba 
                     (ID, Data_Hora_Inicio, Data_Hora_Fim,  Bomba_ID) 
                     VALUES (@ID, @Data_Hora_Inicio, @Data_Hora_Fim,  @Bomba_ID)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", PFB.ID);
                    cmd.Parameters.AddWithValue("@Data_Hora_Inicio", PFB.Data_Hora_Inicio);
                    cmd.Parameters.AddWithValue("@Data_Hora_Fim", PFB.Data_Hora_Fim);
                    cmd.Parameters.AddWithValue("@Bomba_ID", PFB.Bomba_ID.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}    