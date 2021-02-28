using System.IO;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public class DatabaseConnection
    {
        public static SQLiteConnection con = new SQLiteConnection("URI = file:" + Directory.GetCurrentDirectory() + @"\Database.sqlite", true);//stvaranje veze s lokalnom bazom podataka --> trenutno koristi SQL server     
        public static SQLiteCommand cmd = new SQLiteCommand(con);
        public static void ConnectionClose()
        
        {
            con.Close(); 
        }
        public static void ConnectionOpen()
        {
            if (con.State != System.Data.ConnectionState.Open) con.Open();
        }
        public static void CheckAndCreateDatabase()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\Database.sqlite"))//provjera postoji li već baza podataka
            {
                SQLiteConnection.CreateFile(Directory.GetCurrentDirectory() + @"\Database.sqlite");//stvaranje baze podataka
                ConnectionOpen();             
                cmd.CommandText = @"CREATE TABLE BloodPressure(Id INTEGER PRIMARY KEY,
                    DATE INT, SYS INT, DIA INT, HR INT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE BloodSugar(Id INTEGER PRIMARY KEY,
                    DATE INT, BS INT)";
                cmd.ExecuteNonQuery();
            }                      
        }
    }
}
