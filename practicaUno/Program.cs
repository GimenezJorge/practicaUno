using practicaUno.Models;

class Program
{
    static void Main(string[] args)
    {
        Bebida bebida= new Bebida();
        Bebida bebida2 = new Bebida("fanta", 500);
        
        //bebida.nombre = "coquita";
        //bebida.cantidad = 500;

        bebida.SetNombre("Coquita");
        bebida.SetCantidad(500);

        bebida.tomarse(100);
        bebida2.tomarse(100);

        Console.WriteLine("Le quedan  " + bebida.cantidad + " de la bebida " + bebida.nombre);
        Console.WriteLine(bebida2.cantidad);
    }
}