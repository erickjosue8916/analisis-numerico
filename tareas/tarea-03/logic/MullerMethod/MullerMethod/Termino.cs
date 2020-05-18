using System;


namespace MullerMethod
{
    public class Termino
    {
        public String text;
        public Termino(double coeficiente, double exponente)
        {
            this.Coeficiente = coeficiente;
            this.Exponente = exponente;

            this.text = " ";
            this.setText(coeficiente, exponente);
        }

        public double Coeficiente { get; set; }
        public double Exponente { get; set; }

        public double operar(double number)
        {
            return this.Coeficiente * Math.Pow(number, this.Exponente);
        }

        private void setText(double coeficiente, double exponente)
        {
            if (coeficiente >= 0) this.text += "+";
            if (coeficiente != 1)this.text += $"{coeficiente}";
            if (exponente != 0) this.text += $"x^{exponente}";
        }
    }

    
}