﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public Cerveza(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {
        }

        public Cerveza() { }

        public int alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de birras es cinco latas por persona");
        }
    }

}
