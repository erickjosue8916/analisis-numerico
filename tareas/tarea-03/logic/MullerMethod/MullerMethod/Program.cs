using System;
using System.Collections;
using System.Linq.Expressions;
using Expression = NCalc.Expression;

namespace MullerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Muller muller = new Muller("Pow(x,5)+Pow(x,2)-1", 3, 20);
            
            foreach (String log in muller.historial)
            {
                Console.WriteLine(log);
            }
            
            
            // sacar puntos para graficar
            for (double i = -3; i <= 3; i+=0.01)
            {
                //codigo para agregar los puntos
                Console.WriteLine($"( {Muller.redondeo(i, 2)}, {muller.evaluar(Muller.redondeo(i, 2))} )");
            }
           
            
        }
    }
}