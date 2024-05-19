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
    internal class MesaDAO : Conexion
    {
        public DataTable getMesas()
        {
            try
            {
                string query = "SELECT id_mesa as ID, estado as Estado FROM mesa;";
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
        public void actualizarEstado(Mesa m) {
            string query = "UPDATE mesa SET estado = @estado WHERE id_mesa = @id;";
            MySqlCommand comando = new MySqlCommand(query, conexion());
            comando.Parameters.Add(new MySqlParameter("@estado", m.estado));
            comando.Parameters.Add(new MySqlParameter("@id", m.id));
            comando.ExecuteNonQuery();
        }
        public void agregarMesa(Mesa m) {
            string query = "INSERT INTO mesa (estado) VALUES (@estado);";
            MySqlCommand comando = new MySqlCommand(query, conexion());
            comando.Parameters.Add(new MySqlParameter("@estado", m.estado));
            comando.ExecuteNonQuery();
        }
        public void eliminarMesa(int id) {
            string query = "DELETE FROM mesa WHERE id_mesa = @id_mesa";
            MySqlCommand comando = new MySqlCommand(query, conexion());
            comando.Parameters.Add(new MySqlParameter("@id_mesa", id));
            comando.ExecuteNonQuery();
        }
    }
}
