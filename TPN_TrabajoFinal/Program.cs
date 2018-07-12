using System;
using Libreria_de_clases;
namespace TPN_TrabajoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            PagoAdelantado pago01 = new PagoAdelantado(1, 1000000, 0.08F, 90, 1);

            Console.Write(pago01.getPagoAdelantado());

            Pausa();
        }

        public static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
