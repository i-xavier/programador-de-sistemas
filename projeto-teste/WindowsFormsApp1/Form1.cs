using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculadoraFundo : Form
    {
        public frmCalculadoraFundo()
        {
            InitializeComponent();
        }

        private void ApagarTela(object sender, EventArgs e)
        {
            txtTela.Text = string.Empty;
        }

        private void EscreverTela(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtTela.Text += botao.Text;

        }

        private void Calcular(object sender, EventArgs e)
        {
            string expressao = txtTela.Text;
            var resultado = new DataTable();
            
            double avaliarExpressao = Convert.ToDouble(resultado.Compute(expressao, null));

            txtTela.Text = resultado.ToString();
        }
    }
}
