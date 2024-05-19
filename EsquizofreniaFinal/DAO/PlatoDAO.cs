using EsquizofreniaFinal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.DAO
{
    internal class PlatoDAO : Conexion
    {
        public DataTable getPlatos() {
            try
            {
                string query = "SELECT nombre as Nombre,tamaño as Tamaño,precio as Precio FROM plato;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
            catch (MySqlException error)
            {
                Console.WriteLine(error.ToString());
                return null;
            }
        }
        public void AñadirPlato(Plato p ) {
            string query = "INSERT INTO plato (nombre, tamaño, precio) VALUES (@nombre, @tamaño, @precio);";
            MySqlCommand comando = new MySqlCommand(query, conexion());
            comando.Parameters.Add(new MySqlParameter("@nombre", p.nombre));
            comando.Parameters.Add(new MySqlParameter("@tamaño", p.tamanio));
            comando.Parameters.Add(new MySqlParameter("@precio", p.precio));
            comando.ExecuteNonQuery();
        }
    }
}
