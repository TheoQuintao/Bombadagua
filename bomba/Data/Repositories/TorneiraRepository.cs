using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class TorneiraRepository
    {
        public void AddTorneira(Torneira torneira)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Torneira 
                     (ID, Vazao) 
                     VALUES (@ID, @Vazao)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", torneira.ID);
                    cmd.Parameters.AddWithValue("@Vazao", torneira.Vazao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}    