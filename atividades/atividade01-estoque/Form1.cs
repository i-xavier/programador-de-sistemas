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
        const int LIMITE = 5;

        int qtdEstoque = 10;
        
        public Form1()
        {
            InitializeComponent();

            lblQtd.Text = qtdEstoque.ToString();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                int valor = Convert.ToInt32(txtBox.Text);
                // int.TryParse(txtBox.Text, out int valor);

                

               if (valor > 0)
                {
                    

                    if (qtdEstoque - valor < 0)
                    {
                        lblNotificacao.Text = "Alerta:Valor de saída maior que o valor do estoque.\nTente outro valor.";
                        return;
                    }

                    qtdEstoque -= valor;

                    if (qtdEstoque == 0)
                    {
                        lblNotificacao.Text = "Alerta:Estoque vazio. Por favor, reabasteça este produto.";
                    }
                    else if (qtdEstoque < LIMITE)
                    {
                        lblNotificacao.Text = "Alerta: Baixo estoque.Por favor, reabasteça este produto.";
                    }
                    else
                        lblNotificacao.Text = "Estoque suficiente";

                    lblQtd.Text = qtdEstoque.ToString();
                }

               else
                    lblNotificacao.Text = "Alerta:Valor Inválido.\nTente outra vez.";

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Falha " + ex.Message);
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtBox.Text);
                // int.TryParse(txtBox.Text, out int valor);

                if (valor > 0) 
                {
                    qtdEstoque += valor;

                    lblQtd.Text = qtdEstoque.ToString();

                    if (qtdEstoque >= LIMITE)
                        lblNotificacao.Text = "Foi adicionado mais " + valor.ToString() + " produto(s).\nEstoque Suficiente";


                }
                else
                    lblNotificacao.Text = "Alerta:Valor Inválido.\nTente outra vez.";

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Falha " + ex.Message);
            }
        }
    }
}
