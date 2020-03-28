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
            int dato;
            int suma = 0;
            Console.WriteLine("Suma de 10 numeros\n");
            Console.Write("********************************************\n");
            for (int i = 0; i < numeros.Length; i++)
            {
               
                dato=Data.GetIntegerByConsole("Ingrese el numero en la posicion " + i + ": ");

                numeros[i] = dato;
             
            }
            suma = numeros.Sum();
            Console.Write("********************************************\n");
            Console.WriteLine("\n\nLa suma d los 10 numeros es: " + suma);
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
