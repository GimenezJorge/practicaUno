using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        //constructores mas completos:
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetCantidad()
        {
            return cantidad;
        }
        public void SetCantidad(int cantidad)
        {
            this.cantidad= cantidad;
        }

        //constructor sin parametros:
        public Bebida() { }
        

        public Bebida(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;            
        }


        //metodo
        public void tomarse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }   
}
