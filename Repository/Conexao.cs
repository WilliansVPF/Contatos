using MySql.Data.MySqlClient;

namespace Repository
{
    public class Conexao
    {
        private static string connectionString = Environment.GetEnvironmentVariable("connectionContato");

        public static MySqlConnection GetConnection => new MySqlConnection(connectionString);
    }
}
