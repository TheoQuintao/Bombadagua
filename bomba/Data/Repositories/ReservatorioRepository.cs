using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class ReservatorioRepository
    {
        public void AddReservatorio(Reservatorio reservatorio)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Caixa 
                     (ID, Capacidade, Sensor_SUP, Sensor_INF, Torneira_ID, Ind_Reservatorio) 
                     VALUES (@ID, @Capacidade, @Sensor_SUP, @Sensor_INF, @Torneira_ID, Ind_Reservatorio)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", reservatorio.ID);
                    cmd.Parameters.AddWithValue("@Capacidade", reservatorio.Capacidade);
                    cmd.Parameters.AddWithValue("@Sensor_SUP", reservatorio.Sensor_SUP);
                    cmd.Parameters.AddWithValue("@Sensor_INF", reservatorio.Sensor_INF);
                    cmd.Parameters.AddWithValue("@Torneira_ID", reservatorio.Torneira_ID.ID);
                    cmd.Parameters.AddWithValue("@Ind_Caixa", reservatorio.Ind_Reservatorio);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}    