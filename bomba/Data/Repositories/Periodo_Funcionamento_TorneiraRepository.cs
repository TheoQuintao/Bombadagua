using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class Periodo_Funcionamento_TorneiraRepository
    {
        public void AddBomba(Bomba bomba)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Periodo_Funcionamento_Torneira 
                     (ID, Vazao) 
                     VALUES (@ID, @Vazao)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", bomba.ID);
                    cmd.Parameters.AddWithValue("@Vazao", bomba.Vazao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}    