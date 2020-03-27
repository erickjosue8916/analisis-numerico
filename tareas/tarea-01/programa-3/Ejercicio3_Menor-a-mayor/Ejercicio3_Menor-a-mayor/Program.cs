using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Menor_a_mayor
{
    class Program
    {
        private int[] num;
        private int cantidad = 0;
        public void Ingresar()
        {
           

            Console.WriteLine("Ingrese la cantidad de numeros que desea ordenar: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************************\n");
            num = new int[cantidad];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Ordenar()
        {
            for (int j = 0; j < cantidad-1; j++)
            {
                
                for (int i = 0; i < cantidad-1; i++)
                {
                    
                        if (num[i] > num[i+1])
                        {
                            int aux;
                            aux = num[i];
                            num[i] = num[i+ 1];
                            num[i + 1] = aux;

                        }
                    
                    
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("****************************************************\n");
            Console.WriteLine("Ordenando numeros de Menor a Mayor con un arreglo de "+cantidad+" numeros:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("****** "+num[i].ToString());
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Program MenorMayor = new Program();
            MenorMayor.Ingresar();
            MenorMayor.Ordenar();
            MenorMayor.Mostrar();
            
            Console.ReadKey();
        }
    }
}
