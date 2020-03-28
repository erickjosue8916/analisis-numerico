using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Menor_a_mayor
{
    class Program
    {
        private int[] arreglo;
        int num;
        private int cantidad = 0;
        public void Ingresar()
        {
           
    
            cantidad=Data.GetIntegerByConsole("Ingrese la cantidad de numeros que desea ordenar: ");
           /* Console.WriteLine("Ingrese la cantidad de numeros que desea ordenar: ");
            cantidad = int.Parse(Console.ReadLine());*/
            Console.WriteLine("****************************************************\n");
            arreglo = new int[cantidad];
            for (int i = 0; i < arreglo.Length; i++)
            {
                num=Data.GetIntegerByConsole("Ingrese el numero en la posicion " + i + ": ");
                /*Console.WriteLine("Ingrese el numero en la posicion " + i + ": ");
                num = int.Parse(Console.ReadLine());*/
              
                
                
                
                arreglo[i]= num;
            }
        }
        public void Ordenar()
        {
            for (int j = 0; j < cantidad-1; j++)
            {
                
                for (int i = 0; i < cantidad-1; i++)
                {
                    
                        if (arreglo[i] > arreglo[i+1])
                        {
                            int aux;
                            aux = arreglo[i];
                            arreglo[i] = arreglo[i+ 1];
                            arreglo[i + 1] = aux;

                        }
                    
                    
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("****************************************************\n");
            Console.WriteLine("Ordenando numeros de Menor a Mayor con un arreglo de "+cantidad+" numeros:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("****** "+arreglo[i].ToString());
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
//***********************************************************************************************************//
class Data
{
    public static int GetIntegerByConsole(String message)
    {
        try
        {
            int number;
            ConsoleMessage.Print(message, 1);
            number = int.Parse(Console.ReadLine());
            return number;
        }
        catch (Exception e)
        {
            ConsoleMessage.Print("Entrada invalida", 3);
            return GetIntegerByConsole(message);
        }
    }
    public static double GetDoubleByConsole(String message)
    {
        try
        {
            double number;
            ConsoleMessage.Print(message, 1);
            number = double.Parse(Console.ReadLine());
            return number;
        }
        catch (Exception e)
        {
            ConsoleMessage.Print("Entrada invalida", 3);
            return GetIntegerByConsole(message);
        }
    }

    public static String GetStringByConsole(String message)
    {
        String data;
        do
        {
            ConsoleMessage.Print(message, 1);
            data = Console.ReadLine();
        } while (data == "");

        return data;
    }
}

class ConsoleMessage
{
    // print message in console 
    // @Param message: text 
    // @Param type: 1: inline, 2: oneLine, 3: decorate
    public static void Print(String message, int type)
    {
        switch (type)
        {
            case 1:
                Console.Write(message);
                break;
            case 2:
                Console.WriteLine(message);
                break;
            default:
                message = $"*********************************\n{message}\n*****************************";
                Console.WriteLine(message);
                break;
        }
    }
}
