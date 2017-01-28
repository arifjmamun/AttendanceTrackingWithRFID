
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Attendance.DAL
{
    class DBconnection
    {
        protected MySqlConnection Connection;
        protected MySqlCommand Command;
        protected MySqlDataReader Reader;
        protected MySqlDataAdapter Adapter;

        public DBconnection()
        {
            Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            Command = new MySqlCommand();
            Command.Connection = Connection;
        }
    }
}
