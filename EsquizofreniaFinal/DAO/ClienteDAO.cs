using EsquizofreniaFinal.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.DAO
{
    internal class ClienteDAO : Conexion
    {
        public void registrarCliente(Cliente c) {

            string query = "INSERT INTO cliente (dni, user, password) VALUES (@dni, @user, @password);";

            MySqlCommand command = new MySqlCommand(query, conexion());
            command.Parameters.Add(new MySqlParameter("@dni", c.dni));
            command.Parameters.Add(new MySqlParameter("@user", c.user));
            command.Parameters.Add(new MySqlParameter("@password", c.password));
            command.ExecuteNonQuery();
        }

        public bool login(Cliente c) {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE user = @user and password = @pwd;";
                MySqlCommand command = new MySqlCommand(query, conexion());
                command.Parameters.Add(new MySqlParameter("@user", c.user));
                command.Parameters.Add(new MySqlParameter("@pwd", c.password));
                int cantidadRegistros = Convert.ToInt32(command.ExecuteScalar());
                return cantidadRegistros == 1;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
            

        }
    }
}
