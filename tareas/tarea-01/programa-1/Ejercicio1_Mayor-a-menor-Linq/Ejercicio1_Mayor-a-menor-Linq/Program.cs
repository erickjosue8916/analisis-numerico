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
                    dato=Data.GetIntegerByConsole("Ingrese el numero en la posicion " + i + ":");
                   
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