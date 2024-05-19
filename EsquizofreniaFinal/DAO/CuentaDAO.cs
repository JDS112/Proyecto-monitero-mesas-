using EsquizofreniaFinal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.DAO
{
    internal class CuentaDAO : Conexion
    {
        public void agregarCuenta(Cuenta cuenta) {
            string query = "INSERT INTO cuenta (Mesa_ID, precio, fecha) VALUES (@Mesa_ID, @precio, @fecha);";
            MySqlCommand comando = new MySqlCommand(query, conexion());
            comando.Parameters.Add(new MySqlParameter("@Mesa_ID", cuenta.idMesa));
            comando.Parameters.Add(new MySqlParameter("@precio", cuenta.precioTotal));
            comando.Parameters.Add(new MySqlParameter("@fecha", cuenta.fecha));
            comando.ExecuteNonQuery();
        }
    }
}
