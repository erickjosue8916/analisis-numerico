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
using System.Windows.Forms.DataVisualization.Charting;

namespace Metodo_Muller_form
{
   
    public partial class App : Form
    {
        public void ejecutar (String expression, int maxIteraciones, double maxError, double x0, double x1, double x2)
        {
            Muller m = new Muller(expression, maxIteraciones, maxError, x0, x1, x2);

            foreach (var item in m.historial)
            {
                Console.WriteLine(item);
            }

            limpiarGrafica();
            for (double i = -3; i < 3; i += 0.5)
            {
                grafica.Series[0].Points.AddXY(i, m.evaluar(i));
                //grafica.Series[1].Points.AddXY(i, m.evaluarParabola(i));
            }
        }
        public void limpiarGrafica()
        {
            foreach (var series in grafica.Series)
            {
                series.Points.Clear();
            }
        }
        public App()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += ("Pow(x, potencia)");
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
                MessageBox.Show($"Ingrese todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string expression = txtExpresion.Text;
                double x0 = double.Parse(txtx0.Text);
                double x1 = double.Parse(txtx1.Text);
                double x2 = double.Parse(txtx2.Text);
                int maxIteraciones = int.Parse(txtMaxItera.Text);
                double maxError = double.Parse(txtMaxError.Text);

                ejecutar(expression, maxIteraciones, maxError, x0, x1, x2);
            }

        }



        //Validaciones-----------------------------------------------------------

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

        private void txtx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "-")
            {
                e.Handled = true;
                return;
            }
        }

        private void txtx0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "-")
            {
                e.Handled = true;
                return;
            }
        }

        private void txtx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "-")
            {
                e.Handled = true;
                return;
            }
        }
    }
}
