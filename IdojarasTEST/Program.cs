using MySql.Data.MySqlClient;

namespace IdojarasSQL
{
    internal class Program
    {
        private static string server = "localhost";
        private static string database = "idojaras3";
        private static string user = "root";
        private static string password = "";
        private static List<Januar> januarList = new List<Januar>();
        /*teszt hihi*/
        private static string connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        static void Main(string[] args)
        {
            KapcsolodasAdatbazishoz();
        }

        private static void KapcsolodasAdatbazishoz()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Kapcsolat sikeresen megnyitva.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba a kapcsolat megnyitásakor: " + ex.Message);
            }
        }
    }
}