using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = "";

            resultado = resultado + Operar(this.txtNumeroUno.Text, txtNumeroDos.Text, this.cmbOperador.Text);

            this.lblResultado.Text = resultado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }

        private void Limpiar()
        {
            this.txtNumeroUno.Text = " ";
            this.txtNumeroDos.Text = " ";
            this.cmbOperador.ResetText();
            this.lblResultado.Text = " ";

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double aux = 0;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            aux = Calculadora.Operar(num1, num2, operador);

            return aux;
        }
    }
}
