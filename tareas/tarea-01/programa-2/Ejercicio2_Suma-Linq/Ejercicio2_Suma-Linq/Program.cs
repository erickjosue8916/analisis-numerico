using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Suma_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;
            Console.WriteLine("Suma de 10 numeros\n");
            Console.Write("********************************************\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + i + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
             
            }
            suma = numeros.Sum();
            Console.Write("********************************************\n");
            Console.WriteLine("\n\nLa suma d los 10 numeros es: " + suma);
            Console.ReadKey();
        }
    }
}
