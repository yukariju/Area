﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcule_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;

            n1 = double.Parse(txtboxbase.Text);
            n2 = double.Parse(txtboxaltura.Text);
            resultado = (n1 * n2) / 2;

            lblresultado.Text = resultado.ToString();

            
        }

       
    }
}
