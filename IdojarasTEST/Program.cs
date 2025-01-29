using IdojarasTEST;
using MySql.Data.MySqlClient;

namespace IdojarasSQL
{
    internal class Program  /* <------ EZ is egy osztály, oda van írva */
    {
        private static string server = "localhost";
        private static string database = "idojaras3";
        private static string user = "root";
        private static string password = "";
        private static List<Januar> januarList = new List<Januar>();
        private static List<Meteorologus> MetList = new List<Meteorologus>();
        /*teszt hihi*/
        private static string connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        static void Main(string[] args)
        {
            KapcsolodasAdatbazishoz();
            SelectTable("idojaras") /* <-----   Paraméteres függvényhasználat 😊*/;
            for (int i = 0; i < januarList.Count; i++) 
            {
                Console.WriteLine(januarList[i].ToString());
            }
            Beolvasas();
            UjSor();
            AtlagHomerseklet();
            LegnagyobbParatartalom();
            MeteorologusBeolvas("meteorologusok");
            EloMeteorologusok();
        }

        private static void EloMeteorologusok()
        {

            for (int i = 0; i < MetList.Count; i++)
            {
                if (MetList[i].SzulEv > 1935 )
                {
                    Console.WriteLine(MetList[i].ToString());
                }
            }

        }

        private static void MeteorologusBeolvas(string v)
        {
            using (MySqlCommand command = new MySqlCommand($"select * from {v}", connection))
            {
                MetList.Clear();
                using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {                    
                        Meteorologus MetTemp = new Meteorologus(Convert.ToInt32(mySqlDataReader[0]), Convert.ToString(mySqlDataReader[1]), Convert.ToInt32(mySqlDataReader[2]));
                        MetList.Add(MetTemp);
                    }
                }
            }
        }

        private static void LegnagyobbParatartalom()
        {
            int maxPara = 0;
            int sameDb = 0;
            for (int i = 0;i < januarList.Count; i++)
            {
                if (januarList[i].Parataltalom > maxPara)
                {
                    maxPara = januarList[i].Parataltalom;
                }
                else if (januarList[i].Parataltalom == maxPara)
                {
                    sameDb++;
                }
            }
            Console.WriteLine($"\n-------------------------------------\n A legnagyobb páratartalom: {maxPara}\n Ezt a számot {sameDb} alkalommal érte el ismét");
        }

        private static void AtlagHomerseklet()
        {   
            float AtlagHom = 0;
            int OsszHom = 0;
            for (int i = 0; i < januarList.Count; i++)
            {
                OsszHom += januarList[i].Homerseklet;
            }
            AtlagHom = OsszHom / januarList.Count();
            Console.WriteLine($"\n-------------------------------------\nÁtlag hőmérséklet: \n{AtlagHom}C°");
        }

        private static void UjSor()
        {
            try
            {
                using (MySqlCommand commandInsert = new MySqlCommand($"insert into idojaras (id, datum, homerseklet, csapadek, paratartalom) values (@id, @datum, @homerseklet, @csapadek, @paratartalom)", connection))
                {
                    commandInsert.Parameters.AddWithValue("@id", januarList[januarList.Count() -1].Id);
                    commandInsert.Parameters.AddWithValue("@datum", januarList[januarList.Count() - 1].Datum);
                    commandInsert.Parameters.AddWithValue("@homerseklet", januarList[januarList.Count() - 1].Homerseklet);
                    commandInsert.Parameters.AddWithValue("@csapadek", januarList[januarList.Count() - 1].Csapadek);
                    commandInsert.Parameters.AddWithValue("@paratartalom", januarList[januarList.Count() - 1].Parataltalom);
                    commandInsert.ExecuteNonQuery();

                    Console.WriteLine("Sikeres INSERT!");

                    //Lista újratöltés...
                    SelectTable("idojaras");
                    
                }
            }
            catch (MySqlException mySqlError)
            {
                Console.WriteLine("Sikertelen INSERT");
                Console.WriteLine(mySqlError);
            }
            catch (Exception error)
            {
                Console.WriteLine("Sikertelen INSERT");
                Console.WriteLine(error);
            }
        }

        private static void Beolvasas()
        {
            string FilePath = "SQL.txt";
            if (File.Exists(FilePath))
            {
                string[] sorok = File.ReadAllLines(FilePath);

                for (int i = 0;i < sorok.Length; i++)
                {
                    string[] mezok = sorok[i].Split(';');
                    Januar UjDatom = new Januar(Convert.ToInt32(mezok[0]), Convert.ToInt32(mezok[1]), Convert.ToInt32(mezok[2]), Convert.ToInt32(mezok[3]), Convert.ToInt32(mezok[4]));
                    januarList.Add(UjDatom);
                }
            }
            else
            {
                Console.WriteLine("Valami nem stimmel");
            }
            Console.WriteLine(januarList[januarList.Count()-1].ToString());
        }

        private static void SelectTable(string v)
        {
            using (MySqlCommand command = new MySqlCommand($"select * from {v}", connection))
            {
                januarList.Clear();
                using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        Januar januarTemp = new Januar(Convert.ToInt32(mySqlDataReader[0]), Convert.ToInt32(mySqlDataReader[1]),
                                                       Convert.ToInt32(mySqlDataReader[2]), Convert.ToInt32(mySqlDataReader[3]),
                                                       Convert.ToInt32(mySqlDataReader[4]));
                        januarList.Add(januarTemp);
                    }
                }
            }
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