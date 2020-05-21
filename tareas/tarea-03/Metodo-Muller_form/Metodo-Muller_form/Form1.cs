using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using NCalc;


namespace Metodo_Muller_form
{
   
    public partial class Form1 : Form
    {
       public void ejecutar (String expression, int maxIteraciones, double maxError)
        {
            Muller m = new Muller(expression, maxIteraciones, maxError, 1, 2, 1.5);

            var total = m.x3;
            foreach (var item in m.historial)
            {
                Console.WriteLine(item);
            }
            MessageBox.Show($"El total es {total}","Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarGrafica();
            for (double i = 0; i < 5; i += 0.1)
            {

                grafica.Series[0].Points.AddXY(i, m.evaluar(i));
            }

        }

        public void limpiarGrafica()
        {
            foreach (var series in grafica.Series)
            {
                series.Points.Clear();
            }
        }
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += ("Pow(x, y)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += ("Sqrt(x)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += ("Log(x, base)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtExpresion.Text=="" || txtMaxItera.Text=="" || txtMaxError.Text=="" )
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                string expression = txtExpresion.Text;
                int maxIteraciones = int.Parse(txtMaxItera.Text);
                double maxError = double.Parse(txtMaxError.Text);

                ejecutar(expression, maxIteraciones, maxError);
            }

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaxItera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMaxError_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
                return;
            }
        }
    }
}
