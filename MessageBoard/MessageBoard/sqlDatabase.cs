using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace MessageBoard
{
    sealed partial class sqlDatabase
    {

        private static sqlDatabase _instance;
        public static sqlDatabase Instance { get { return _instance == null ? _instance = new sqlDatabase() : _instance; } }

        SQLiteConnection dbConn = new
        SQLiteConnection("Data Source=data.db;Version=3;");



        public  sqlDatabase()
        {
            if (!File.Exists("data.db"))
                CreateDatabase();
            else
                dbConn.Open();
        }


        private void CreateDatabase()
        {
            //Opretter en ny database
            SQLiteConnection.CreateFile("data.db");
            
          
            dbConn.Open();

            string Mandag = "create table Mandag (id integer primary key, Lokale, Skibsnavn, Aktivitet, Lærer)";
            string Tirsdag = "create table Tirsdag (id integer primary key, Lokale, Skibsnavn, Aktivitet, Lærer)";
            string Onsdag = "create table Onsdag (id integer primary key, Lokale, Skibsnavn, Aktivitet, Lærer)";
            string Torsdag = "create table Torsdag (id integer primary key, Lokale, Skibsnavn, Aktivitet, Lærer)";
            string Fredag = "create table Fredag (id integer primary key, Lokale, Skibsnavn, Aktivitet, Lærer)";

            

            

            SQLiteCommand mandag = new SQLiteCommand(Mandag, dbConn);
            SQLiteCommand tirsdag = new SQLiteCommand(Tirsdag, dbConn);
            SQLiteCommand onsdag = new SQLiteCommand(Onsdag, dbConn);
            SQLiteCommand torsdag = new SQLiteCommand(Torsdag, dbConn);
            SQLiteCommand fredag = new SQLiteCommand(Fredag, dbConn);

            mandag.ExecuteNonQuery();
            tirsdag.ExecuteNonQuery();
            onsdag.ExecuteNonQuery();
            torsdag.ExecuteNonQuery();
            fredag.ExecuteNonQuery();

            //new SQLiteCommand("insert into Mandag values(null, \"2\", \"halløj\", \"kodefis\", \"dm\")", dbConn).ExecuteNonQuery();
            //new SQLiteCommand("insert into Tirsdag values(null, \"3\", \"godav\", \"leg\", \"milo\")", dbConn).ExecuteNonQuery();

            
        }

        public string[] GetValues(Dage dag, int index)
        {
            var sqlr = new SQLiteCommand($"select * from {dag.ToString()} where id={index}", dbConn).ExecuteReader();
            if (!sqlr.HasRows) return null;
            string[] dagsLektion = new string[5];
            sqlr.Read();

            dagsLektion[0] = sqlr.GetValue(0).ToString();
            dagsLektion[1] = sqlr.GetValue(1).ToString();
            dagsLektion[2] = sqlr.GetValue(2).ToString();
            dagsLektion[3] = sqlr.GetValue(3).ToString();
            dagsLektion[4] = sqlr.GetValue(4).ToString();

            return dagsLektion;
        }

        public void Values(int id, Dage dag, string lokale, string skib, string lærer, string aktivitet)
        {
            var sqlr = new SQLiteCommand($"select * from {dag.ToString()} where id={id}", dbConn).ExecuteReader();
            if (sqlr.HasRows)
            {
                new SQLiteCommand($"update { dag.ToString() } set Lokale = \"{lokale}\", Skibsnavn = \"{skib}\", Aktivitet = \"{aktivitet}\", Lærer = \"{lærer}\" where id = {id} ", dbConn).ExecuteNonQuery();
            }
            else
            {
                new SQLiteCommand($"insert into {dag.ToString()} values({id}, \"{lokale}\", \"{skib}\", \"{aktivitet}\", \"{lærer}\")", dbConn).ExecuteNonQuery();
            }
        }

    }
}
