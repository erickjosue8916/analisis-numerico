using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Mayor_a_menor
{
    class Program
    {
        private int[] arreglo;
        int dato;
        bool repetido;
        public void Ingresar()
        {
            Console.WriteLine("Orden de 10 numeros de Mayor a Menor");
            Console.Write("********************************************\n\n");

            arreglo = new int[10];
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
        }

        public void Ordenar()
        {
            for(int j=0;j<9; j++)
            {
                for(int i=0; i<9; i++)
                {
                    if(arreglo[i]<arreglo[i+1])
                    {
                        int aux;
                        aux = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = aux;

                    }
                }
            }
        }

        public void Mostrar()
        {
            Console.Write("********************************************\n\n");
            Console.WriteLine("Ordenando numeros de Mayor a Menor");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("*****  "+arreglo[i].ToString());
            }
            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            Program MayorMenor = new Program();
            MayorMenor.Ingresar();
            MayorMenor.Ordenar();
            MayorMenor.Mostrar();
            Console.ReadKey();

            
        }
    }
}
