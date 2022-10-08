using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            if()
            peso = Double.Parse(txtBxPeso.Text);
            altura = Double.Parse(txtBxAltura.Text);

            imc = peso / (altura * altura);

            imc = Math.Round(imc, 1);

            txtBxIMC.Text = imc.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
