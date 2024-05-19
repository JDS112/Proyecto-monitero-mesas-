using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.Models
{
    internal class Plato
    {
        public string nombre;
        public string tamanio;
        public float precio;

        public Plato(string nombre, string tamanio, float precio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
            this.precio = precio;
        }
    }
}

