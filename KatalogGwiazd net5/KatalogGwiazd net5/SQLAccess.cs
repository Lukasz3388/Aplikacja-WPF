using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Windows;

namespace KatalogGwiazd_net5
{
    class SQLAccess
    {
        //pobierz bibliotekę sqlite microsoft.data.sqlite tam /narzędzia -> menadzer pakietow nuget -> zarzadzaj pakietami /starsza wersja
        public static string dbFileDirectory = Environment.CurrentDirectory;
        public static string dbFilePath = System.IO.Path.Combine(Environment.CurrentDirectory, "database.db");
        private static string _connectionString = string.Format("Data Source = {0}", dbFilePath);

        public static void CreateTableSpaces()
        {
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if(dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = String.Format("CREATE TABLE IF NOT EXISTS Spaces(Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT, Description TEXT, PhotoName TEXT)");
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                int result = dbCommand.ExecuteNonQuery();
                
            }
            dbConnection.Close();
        }
        //Read method
        public static List<SpaceModel> Read()
        {

        
        List<SpaceModel> spacelist = new List<SpaceModel>();
        
        SqliteConnection dbConnection = new SqliteConnection(_connectionString);
        dbConnection.Open();
            if(dbConnection.State == ConnectionState.Open){
            string dbQuery = "SELECT * FROM Spaces";
        SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);

        SqliteDataReader dbDataReader = dbCommand.ExecuteReader();
               
        while(dbDataReader.Read()){
            SpaceModel space = new SpaceModel()
            {
                Id = Convert.ToInt32(dbDataReader["Id"]),
                Title = dbDataReader["Title"].ToString(),
                Description = dbDataReader["Description"].ToString(),
                PhotoName = dbDataReader["PhotoName"].ToString()
            };
                    spacelist.Add(space);
            }
        }
        dbConnection.Close();
        return spacelist;
        }
        //Delete method
        public static bool Delete(SpaceModel item)
        {
            bool isDeleted = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = string.Format("DELETE FROM Spaces WHERE Id = {0}", item.Id);
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                int result = dbCommand.ExecuteNonQuery();
                isDeleted = true;
            }
            dbConnection.Close();
            return isDeleted;
        }
        //Insert Method
        public static bool Create(string aTitle, string aDescription, string aPhotoName)
        {
            bool isCreated = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();

            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = string.Format("INSERT INTO Spaces VALUES( null, '{0}', '{1}', '{2}')", aTitle, aDescription, aPhotoName);
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);

                int result = dbCommand.ExecuteNonQuery();
                isCreated = true;
                
            }
            dbConnection.Close();
            return isCreated;
        }
        //Update Method
        public static bool Update(SpaceModel item, int numerid)
        {
            numerid += 1;
            bool isUpdated = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();

            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = string.Format("UPDATE Spaces SET Title = '{0}', Description = '{1}', PhotoName = '{2}' WHERE ID = '{3}'", item.Title, item.Description, item.PhotoName, numerid);
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);

                int result = dbCommand.ExecuteNonQuery();
                isUpdated = true;
            }
            dbConnection.Close();
            return isUpdated;
        }
    }
}
