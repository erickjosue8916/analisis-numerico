using System;

namespace PromedioEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            int sumAges;
            double promAges;
            int groupLength = 2;
            int[] group = new int[groupLength];
            String message;

            counter = 0;
            do
            {
                group[counter] = Data.GetIntegerByConsole($"Escribe la edad del la persona {counter + 1} en el grupo: ");
                if (group[counter] >= 18) counter++;
               
            } while (counter < groupLength);

            sumAges = 0;
            
            message = $"El promedio de las edades ";
            foreach (int age in group)
            {
                sumAges += age;
                message += $"{age} ";
            }

            promAges = sumAges / groupLength;
            message += $"es: {promAges}";
            ConsoleMessage.Print(message, 3);
        }
        String exit = Console.ReadLine();
    }

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
}