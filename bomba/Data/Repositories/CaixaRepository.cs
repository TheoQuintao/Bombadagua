using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class CaixaRepository
    {
        public void AddCaixa(Caixa caixa, Bomba bomba)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Caixa 
                     (ID, Capacidade, Sensor_SUP, Sensor_INF, Bomba_ID, Ind_Caixa) 
                     VALUES (@ID, @Capacidade, @Sensor_SUP, @Sensor_INF, @Bomba_ID, Ind_Caixa)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", caixa.ID);
                    cmd.Parameters.AddWithValue("@Capacidade", caixa.Capacidade);
                    cmd.Parameters.AddWithValue("@Sensor_SUP", caixa.Sensor_SUP);
                    cmd.Parameters.AddWithValue("@Sensor_INF", caixa.Sensor_INF);
                    cmd.Parameters.AddWithValue("@Bomba_ID", bomba.ID);
                    cmd.Parameters.AddWithValue("@Ind_Caixa", caixa.Ind_Caixa);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
} 
 