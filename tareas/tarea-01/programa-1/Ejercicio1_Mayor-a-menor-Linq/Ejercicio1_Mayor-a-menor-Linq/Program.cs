using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Mayor_a_menor_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("Arreglo de 10 numeros\n");
            Console.Write("********************************************\n");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + i + ":");
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(num);
           
            Array.Reverse(num);
            Console.Write("********************************************\n");
            Console.WriteLine("\n\n*****Arreglo ordenado de Mayor a Menor: *****");
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine("Orden: " + num[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
