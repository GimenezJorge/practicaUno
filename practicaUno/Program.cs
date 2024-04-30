using practicaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5] { 1, 2, 3, 4, 9 };
        int numero1 = numeros[0];

        //Console.WriteLine(numero);
        //Console.WriteLine(numeros.Length);

        for (int i = 0; i < numeros.Length; i++)
        {
            //Console.WriteLine(numeros[i]);
            Console.WriteLine("iteracion: " + i + "-" + numeros[i]);
        }

        Console.WriteLine("-----------------------------");

        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }



        Bebida bebida = new Bebida();
        Bebida bebida2 = new Bebida("fanta", 500);
        //bebida.nombre = "coquita";
        //bebida.cantidad = 500;

        Vino vinoUno = new Vino(50, "tinto");
        bebida.SetNombre("coquita");
        bebida.SetCantidad(1000);
        bebida.tomarse(100);
        bebida2.tomarse(100);


        Console.WriteLine("Le quedan  " + bebida.cantidad + " de la bebida " + bebida.nombre);
        Console.WriteLine(bebida2.cantidad);


    }
}