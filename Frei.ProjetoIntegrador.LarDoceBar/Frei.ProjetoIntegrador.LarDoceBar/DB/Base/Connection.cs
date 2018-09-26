using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=lardocebarDB;uid=root;password=1234;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
