using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.Models
{
    internal class Cliente
    {
        public string dni;
        public string user;
        public string password;
        public string correoElectronico;
        public int idUser;
        public int numTelefono;


        //Registro de cliente
        public Cliente( string user, string dni ,string password)
        {
            this.user = user;
            this.dni = dni;
            this.password = password;

        }
        //Login
        public Cliente(string user, string password)
        {
            this.user = user;
            this.password = password;

        }
        //Reserva
        public Cliente(string correoElectronico, int numTelefono)
        {
            this.numTelefono = numTelefono;
            this.correoElectronico = correoElectronico;

        }

        public Cliente()
        {
        }
    }
}
