using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.Models
{
    internal class Cuenta
    {
        public int idMesa;
        public float precioTotal;
        public DateTime fecha;
        public Cuenta(int idMesa, float precio, DateTime fecha) {
            this.idMesa = idMesa;
            this.precioTotal = precio;
            this.fecha = fecha;
        }
    }
}
