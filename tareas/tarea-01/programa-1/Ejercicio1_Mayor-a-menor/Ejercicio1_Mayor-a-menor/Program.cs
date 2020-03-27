using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Mayor_a_menor
{
    class Program
    {
        private int[] num;
        public void Ingresar()
        {
            Console.WriteLine("Orden de 10 numeros de Mayor a Menor");
            Console.Write("********************************************\n\n");

            num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Ordenar()
        {
            for(int j=0;j<9; j++)
            {
                for(int i=0; i<9; i++)
                {
                    if(num[i]<num[i+1])
                    {
                        int aux;
                        aux = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = aux;

                    }
                }
            }
        }

        public void Mostrar()
        {
            Console.Write("********************************************\n\n");
            Console.WriteLine("Ordenando numeros de Mayor a Menor");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("*****  "+num[i].ToString());
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
