using System;

// Ej 5
//
// Se pide una cantidad y su precio. Hay que hallar el total aplicando un tanto por ciento de
// descuento según la cantidad comprada.
// CANTIDAD DESCUENTO
// 0-10 0%
// 11-30 5%
// 31-50 10%
// +50 15%

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            short precio;
            double total;

            Console.Write("Introducir cantidad:");
            cantidad = int.Parse(Console.ReadLine());
            Console.Write("Introducir precio:");
            precio = short.Parse(Console.ReadLine());

            string texto;
            if (cantidad <= 10)
			{
                total=cantidad*precio;
				texto=$"No obtiene ningún descuento, por tanto el total es de {total} euros";
			}
            else if (cantidad >= 11 && cantidad <=30)
			{
                total=cantidad*precio*0.95;
				texto=$"Tiene un descuento del 5%, por tanto el total es de {total} euros";
			}
            else if (cantidad >= 31 && cantidad <=50)
			{
                total=cantidad*precio*0.9;
				texto=$"Tiene un descuento del 10%, por tanto el total es de {total} euros";
			}
            else if (cantidad >= 51)
			{
                total=cantidad*precio*0.85;
				texto=$"Tiene un descuento del 15%, por tanto el total es de {total} euros";
			}
            else texto=null;

            Console.WriteLine(texto);
        }
    }
}
