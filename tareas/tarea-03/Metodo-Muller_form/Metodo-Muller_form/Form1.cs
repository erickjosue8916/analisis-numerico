﻿using System;
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
            MessageBox.Show($"El total es {total}");
            
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
           
           string expression = txtExpresion.Text;
           int maxIteraciones = int.Parse(txtMaxItera.Text);
           double maxError = double.Parse(txtMaxError.Text);

            ejecutar(expression, maxIteraciones, maxError);
           
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
