using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.Models
{
    internal class Reserva
    {
        public int idReserva;
        public DateTime fecha;
        public TimeSpan hora;
        public Reserva(int idReserva, DateTime fecha, TimeSpan hora)
        {
            this.idReserva = idReserva;
            this.fecha = fecha;
            this.hora = hora;
        }
        public Reserva(DateTime fecha, TimeSpan hora)
        {
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}
