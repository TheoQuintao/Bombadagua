using Bomba_Name.Models;
using MySql.Data.MySqlClient;
namespace Bomba_Name.Repositories
{
    public class Media_TempRepository
    {
        public void AddMedia_Temp(Media_Temp media)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Media_Temp 
                     (ID, Media_Fun_Bomba, Media_Fun_Torneira, Periodo_Funcionamento_Bomba_ID, Periodo_Funcionamento_Torneira_ID) 
                     VALUES (@ID, @Media_Fun_Bomba, @Media_Fun_Torneira, @Periodo_Funcionamento_Bomba_ID, @Periodo_Funcionamento_Torneira_ID)";

                using (var cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@Media_Fun_Bomba", media.Media_Fun_Bomba);
                    cmd.Parameters.AddWithValue("@Media_Fun_Torneira", media.Media_Fun_Torneira);
                    cmd.Parameters.AddWithValue("@Periodo_Funcionamento_Bomba_ID", media.Periodo_Funcionamento_Bomba_ID.ID);
                    cmd.Parameters.AddWithValue("@Periodo_Funcionamento_Torneira_ID", media.Periodo_Funcionamento_Torneira_ID.ID);

                    cmd.ExecuteNonQuery();
                    if (cmd.LastInsertedId != 0)
                    {
                        media.ID = (int)cmd.LastInsertedId;
                    }
                }
            }
        }
    }
}    