using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNumalet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                var numero = Convert.ToDecimal(txtNumero.Text);
                //Configuración Numalet
                var numaletSinDecimales = new NumaletNumeroEntero();

                var numaletConDecimales = new NumaletNumeroDecimal();

                //Número entero
                if(numero % 1 == 0)
                {
                    lblTipo.Text = "Número entero";
                    lblResultado.Text = numaletSinDecimales.ToCustomString(numero);
                }
                //Número decimal
                else
                {
                    lblTipo.Text = "Número decimal";
                    lblResultado.Text = numaletConDecimales.ToCustomString(numero);
                }
            }
        }
    }
}
