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

            int[] arreglo = new int[10];
            int dato;
            bool repetido;
            Console.WriteLine("Arreglo de 10 numeros\n");
            Console.Write("********************************************\n");
            //   Console.WriteLine("Ingrese el numero: ");

            
                for (int i = 0; i < arreglo.Length; i++)
                {
                    do
                    {
                         Console.WriteLine("Ingrese el numero en la posicion " + i + ":");
                         dato = int.Parse(Console.ReadLine());
                         arreglo[i] = dato;
                         repetido = false;
                   
                        for (int j = 0; j < i; j++)
                        {
                            if (arreglo[j] == dato)
                            {
                                repetido = true;
                                Console.WriteLine("\nEL NUMERO INGRESADO YA EXISTE, INTENTE NUEVAMENTE! ");
                            }
                        
                    }
                   
                    } while (repetido == true);
                }

            Array.Sort(arreglo);
            Array.Reverse(arreglo);
            Console.Write("********************************************\n");
            Console.WriteLine("\n\n*****Arreglo ordenado de Mayor a Menor: *****");
            for (int i = 0; i < arreglo.Length; i++)
            {

                Console.WriteLine("Orden: " + arreglo[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
