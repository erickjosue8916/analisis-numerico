using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using NCalc;

namespace Metodo_Muller_form
{
    class Muller
    {
        private String expression;
        private double maxIteraciones;
        private double maxError;
        private double iteracionActual;
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


        public Muller(String expression, int maxIteraciones, double maxError, double x1, double x2, double x3)
        {
            this.expression = expression;
            this.maxIteraciones = maxIteraciones;
            this.maxError = maxError;
            this.iteracionActual = 1;
            this.historial = new ArrayList();

            this.historial.Add($"define expresion como {expression}");
            this.calcularX3(x1, x2, x3);
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

        private void definirVariables()
        {
            this.f0 = Muller.redondeo(evaluar(this.x0), 2);
            this.historial.Add($"define f({x0}) = {f0}");

            this.f1 = evaluar(this.x1);
            this.historial.Add($"define f({x1}) = {f1}");

            this.f2 = evaluar(this.x2);
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

        private void calcularX3(double x0, double x1, double x2)
        {

            this.setVaribles(x0, x1, x2);
            this.definirVariables();
            double bajoRaiz = (this.b * this.b) - 4 * (this.a * this.c);
            this.historial.Add($"define raiz(interno) = {bajoRaiz}");
            if (bajoRaiz < 0)
            {
                this.resuelto = false;
                this.message = "Raiz Negativa";
                bajoRaiz = Math.Abs(bajoRaiz);
                this.historial.Add($"Numero imaginario haciendo raiz positiva : raiz(interno) = {bajoRaiz} ");
            }
            //resuelto = true;
            double b = Math.Sqrt(bajoRaiz);
            double denominadorConSignoMas = (this.b) + b;
            this.historial.Add($"Calculando denominador con signo positivo = {denominadorConSignoMas} ");
            double denominadorConSignoMenos = (this.b) - b;
            this.historial.Add($"Calculando denominador con signo menos = {denominadorConSignoMenos} ");
            double denominador = (denominadorConSignoMas > denominadorConSignoMenos) ? denominadorConSignoMas : denominadorConSignoMenos;
            this.historial.Add($"Calculando denominador mas bajo (utilizar) = {denominadorConSignoMenos} ");
            
            if (this.b < 0) b *= -1;

            this.x3 = this.x2 + ((-2 * this.c) / denominador);
            this.historial.Add($"Calcular x3 = x2 + ( -2c ) / (b (+-) Sqrt(b^2 - 4ac)) ");
            this.x3 = Math.Round(this.x3 * 100) / 100;
            this.historial.Add($"solucion x3 = {x3}");
            this.errorAproximacion = Math.Abs((this.x3 - this.x2) / this.x3) * 100;
            this.historial.Add($"error = {this.errorAproximacion}%");
            if (errorAproximacion <= maxError)
            {
                this.historial.Add($"respuesta encontrada X3 = {this.x3}, iterciones {this.iteracionActual}");

            }
            else if (iteracionActual <= maxIteraciones)
            {
                this.iteracionActual++;
                this.historial.Add($"error no aceptable = {this.errorAproximacion}, realizar la iteracion: {this.iteracionActual}");
                this.historial.Add($"Corriendo valores x0 = x1, x1 = x2, x2 = x3 ");
                this.calcularX3(this.x1, this.x2, this.x3);
            }
            else
            {
                this.historial.Add($"error no aceptable = {this.errorAproximacion}, maximo de iteraciones realizadas");
            }
        }

        public double evaluar(double x)
        {
            String e = this.expression;
            e = e.Replace("x", x.ToString());
            Expression exp = new Expression(e);
            return double.Parse(exp.Evaluate().ToString());
        }

        public static double redondeo(double numero, double decimales)
        {
            double d = Math.Pow(10, decimales);
            return (Math.Round(numero * d) / d);
        }
    }
}
