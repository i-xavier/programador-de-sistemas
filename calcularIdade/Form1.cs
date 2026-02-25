using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularIdade
{
    public partial class frmCalcularIdade : Form
    {
        public frmCalcularIdade()
        {
            InitializeComponent();
        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*try { 
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    int calcularIdade = int.Parse(txtAnoAtual.Text) - int.Parse(txtAnoNasc.Text);
                    lblIdade.Text = calcularIdade.ToString();

                }
            } 
            catch 
            {

                MessageBox.Show("Digite um valor válido", "Erro");
            
            }*/
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                int anonascimento, anoatual, idade;

                if (int.TryParse(txtAnoNasc.Text, out anonascimento) && int.TryParse(txtAnoAtual.Text, out anoatual))
                { 
                    idade = anoatual - anonascimento;
                    lblIdade.Text = idade.ToString();
                
                }
                else
                {
                    MessageBox.Show("Digite valores válidos");
                }
            }

        }
    }
}
