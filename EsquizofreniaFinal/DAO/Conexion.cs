using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.DAO
{
    internal class Conexion
    {
        public string sv = "localhost";
        public string bd = "esquizofrenia";
        public string user = "root";
        public string pwd = "rl117";
        public MySqlConnection conexion()
        {

            string cadenaConexion = ($" Database = {bd}; DataSource = {sv}; User Id = {user}; Password = {pwd}");
            MySqlConnection c = new MySqlConnection(cadenaConexion);
            try
            {
                c.Open();

            }
            catch (MySqlException error)
            {
                Console.WriteLine(error.ToString());


            }
            return c;
        }

    }
}
