using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Vino : Bebida
    {
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {
        }
    }
}