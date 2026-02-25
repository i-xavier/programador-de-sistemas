using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade01
{
    public partial class Form1 : Form
    {
        int qtdEstoque = 10;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                int valor = TryParse(txtBox.Text);

                qtdEstoque -= valor;

                if (qtdEstoque < 5)
                {
                    lblNotificacao.Text = "Alerta: Baixo estoque.Por favor, reabasteça este produto.";
                }
                else
                    lblNotificacao.Text = "Estoque suficiente";

                lblQtd.Text = qtdEstoque.ToString();
            }
            catch
            {
                MessageBox.Show("Valor inválido", "Erro");
            }
        }
    }
}
