using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsquizofreniaFinal.Models
{
    internal class Mesa
    {
        public int id;
        public string estado;
        public Mesa(int id, string estado)
        {
            this.id = id;
            this.estado = estado;
        }

        public Mesa(string estado)
        {
            this.estado = estado;
        }

    }
}
