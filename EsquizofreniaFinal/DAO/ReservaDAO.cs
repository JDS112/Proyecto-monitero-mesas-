using EsquizofreniaFinal.Models;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.DAO
{
    internal class ReservaDAO : Conexion
    {
        public void ReservarMesa(string numTelefono, string correo, Mesa m, Reserva r) {
            string clienteReserva = "INSERT INTO reserva (num_telefono, fecha, hora, correo, mesa_id_mesa ) VALUES (@num_telefono, @fecha, @hora, @correo, @mesa_id_mesa);";
            MySqlCommand comando = new MySqlCommand(clienteReserva, conexion());
            comando.Parameters.Add(new MySqlParameter("@num_telefono",numTelefono));
            comando.Parameters.Add(new MySqlParameter("@fecha", r.fecha));
            comando.Parameters.Add(new MySqlParameter("@hora", r.hora));
            comando.Parameters.Add(new MySqlParameter("@correo",correo));
            comando.Parameters.Add(new MySqlParameter("@mesa_id_mesa", m.id));
            comando.ExecuteNonQuery();
            string mesaFalse = "UPDATE mesa SET estado = @estado WHERE id_mesa = @id;";
            MySqlCommand comando2 = new MySqlCommand(mesaFalse, conexion());
            comando2.Parameters.Add(new MySqlParameter("@estado", "Reservada"));
            comando2.Parameters.Add(new MySqlParameter("@id", m.id));
            comando2.ExecuteNonQuery();
        }
    }
}
