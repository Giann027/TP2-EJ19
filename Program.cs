using System;

namespace TP2_EJ19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenasss");
            Console.Title = "Superficie y Perimetro de un Rectángulo + exigencia lado > 0 ";

            float Lado, Superficie, Perimetro;

            Console.Write("Ingrese el lado mayor del rectángulo: ");
            Lado = Convert.ToSingle(Console.ReadLine());

            Superficie = Lado * Lado;

            Perimetro = 4 * Lado;

            if (Lado >= 0)
                Console.WriteLine($"Para esas dimensiones, tendremos una superficie de {Superficie} mtrs^2 y un Perímetro de {Perimetro} mtrs ");
            else
                Console.WriteLine($"Error, por favor ingrese un valor mayor que cero ");
        }
    }
}
