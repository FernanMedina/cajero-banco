using System;
//Este algoritmo representa el cajero de un banco
namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fondos = 5000, sustraccion = 0;
            char salir = '0';

            while (salir != '1')
            {
                Console.WriteLine("Indique el monto a sustraer");
                sustraccion = int.Parse(Console.ReadLine());

                if (fondos - sustraccion > 0)
                {
                    fondos -= sustraccion;
                    Console.WriteLine("Los fondos disponibles son: " + fondos);
                    Console.WriteLine("La sustraccion a realizar es: " + sustraccion);
                }
                else
                {
                    Console.WriteLine("Error, fondos insuficientes");
                }
                Console.WriteLine("Pulse 1 para salir");
                Console.WriteLine("Si desea realizar otra operacion oprima cualquier tecla");
                salir = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finalizo ejecucion");
        }
    }
}
