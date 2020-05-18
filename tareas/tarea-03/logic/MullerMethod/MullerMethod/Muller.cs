using System;
using System.Collections;
namespace MullerMethod
{
    class Muller
    {
        private Funcion expression;
        private double maxIteraciones = 5;
        private double x0;
        private double x1;
        private double x2;
        public double x3;
        private double f0;
        private double f1;
        private double f2;
        private double h0;
        private double h1;
        private double d0;
        private double d1;
        private double a;
        private double b;
        private double c;
        private double errorAproximacion;
        public bool resuelto;
        public String message;
        public ArrayList historial;


        public Muller(Funcion expression)
        {
            this.expression = expression;
            this.historial = new ArrayList();
            this.historial.Add($"define expresion como {this.expression.text}");
            this.setVaribles(1, 2, 1.5);
            this.calcularX3();           
        }

        private void setVaribles(double x0, double x1, double x2)
        {
            this.x0 = x0;
            this.historial.Add($"define x0 = {x0}");
            
            this.x1 = x1;
            this.historial.Add($"define x1 = {x1}");
            
            this.x2 = x2;
            this.historial.Add($"define x2 = {x2}");
            
        }

        private void defiinirVariables()
        {
            this.f0 = expression.evaluar(this.x0);
            this.historial.Add($"define f({x0}) = {f0}");
            
            this.f1 = expression.evaluar(this.x1);
            this.historial.Add($"define f({x1}) = {f1}");
            
            this.f2 = expression.evaluar(this.x2);
            this.historial.Add($"define f({x2}) = {f2}");
            
            this.h0 = this.x1 - this.x0;
            this.historial.Add($"define h0 = {h0}");
            
            this.h1 = this.x2 - this.x1;
            this.historial.Add($"define h1 = {h1}");
            
            this.d0 = (this.f1 - this.f0) / this.h0;
            this.historial.Add($"define d0 = {d0}");
            
            this.d1 = (this.f2 - this.f1) / this.h1;
            this.historial.Add($"define d1 = {d1}");
            
            this.a = (this.d1 - this.d0) / (this.h1 + this.h0);
            this.historial.Add($"define a = {a}");
            
            this.b = (this.a * this.h1) + this.d1;
            this.historial.Add($"define b = {b}");
            
            this.c = this.f2;
            this.historial.Add($"define c = {c}");
        }

        private void calcularX3()
        {
            this.defiinirVariables();
            double bajoRaiz = (this.b * this.b) - 4 * (this.a * this.c);
            this.historial.Add($"define raiz(interno) = {bajoRaiz}");
            if (bajoRaiz < 0)
            {
                this.resuelto = false;
                this.message = "Raiz Negativa";
                bajoRaiz = Math.Abs(bajoRaiz);
                this.historial.Add($"Numero imaginario haciendo raiz positiva : raiz(interno) = {bajoRaiz} ");
            }
            resuelto = true;
            double b = Math.Sqrt(bajoRaiz);
            double denominadorConSignoMas = (this.b) + b;
            double denominadorConSignoMenos = (this.b) + b;
            double denominador = (denominadorConSignoMas < denominadorConSignoMenos) ? denominadorConSignoMas : denominadorConSignoMenos;
            if (this.b < 0) b *= -1;
            this.x3 = this.x2 + ((-2 * this.c) / denominador);
            this.historial.Add($"solucion x3 = {x3}");
            this.errorAproximacion = Math.Abs((this.x3 - this.x2) / this.x3) * 100;
            this.historial.Add($"error = {this.errorAproximacion}%");
        }

    }
    
}