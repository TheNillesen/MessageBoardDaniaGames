using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace MessageBoard
{
    sealed partial class Database
    {
        SQLiteConnection dbConn = new
        SQLiteConnection("Data Source=data.db;Version=3;");


        public void DataBridge()
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



        }



    }
}
