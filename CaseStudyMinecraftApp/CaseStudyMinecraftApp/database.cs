using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyMinecraftApp
{
    internal class database
    {
        private const string ConnectionString = "Data Source=database.db";
        private void getvalues(){
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            string querystring = "SELECT * FROM categorie";
            SQLiteCommand command = new SQLiteCommand(querystring, connection);
            SqlDataReader reader = command.ExecuteReader();
            connection.Open();
            connection.Close();
        }
    }
}
