using MySql.Data.MySqlClient;
public static class DatabaseConnection
{
    private static string connectionString = "server=localhost;database=Banco_Bomba;user=root;password=1234;";
    
    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}