using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Menor_a_Mayor_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea ordenar: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************************\n");
            int[] num = new int[cantidad];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + i + ":");
                num[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(num);
            Array.Sort(num);
            Console.WriteLine("****************************************************\n");
            Console.WriteLine("Ordenando numeros de Menor a Mayor con un arreglo de " + cantidad + " numeros:");
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine("*****"+num[i].ToString());

            }
            Console.ReadKey();
        }
    }
}
