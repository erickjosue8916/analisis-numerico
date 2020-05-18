using System;
using System.Collections;
namespace MullerMethod
{
    class Funcion
    {
        private ArrayList expresion;
        public String text; 
        public Funcion()
        {
            expresion = new ArrayList();
            this.text = "";
        }

        public void agregarTermino(Termino termino)
        {
            expresion.Add(termino);
            this.text += termino.text;
        }

        public double evaluar(double x)
        {
            double result = 0;
            foreach (Termino termino in expresion)
            {
                result += termino.operar(x);
            }

            return result;
        }
    }
}