using System;
using System.Collections.Generic;
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
            connection.Open();
            connection.Close();
        }
    }
}
