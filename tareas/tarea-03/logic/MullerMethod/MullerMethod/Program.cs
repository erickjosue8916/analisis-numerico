using System;
using System.Collections;

namespace MullerMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Termino t1 = new Termino(1, 5); // 5X^3
            Termino t2 = new Termino(1, 2); // -1.2X^3
            Termino t3 = new Termino(-1, 0); // -1.2X^3
            Funcion f = new Funcion(); // f(x) = x^5 + x^3 -1
            f.agregarTermino(t1);
            f.agregarTermino(t2);
            f.agregarTermino(t3);
            Muller muller = new Muller(f);
            foreach (String log in muller.historial)
            {
                Console.WriteLine(log);
            }
            /*if (muller.resuelto)
            {
                Console.WriteLine($"La resolucion es: {muller.x3} "); // f(5) = 5((5)^3) + 1.2((5)^3)    
            }
            else
            {
                
                Console.WriteLine($"Error : {muller.message} ");
            }*/
            
        }
    }
}