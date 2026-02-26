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

                

               if (valor > 0) // verifica se o valor inserido é um número natural positivo
                {
                    

                    if (qtdEstoque - valor < 0) // verifica se o valor inserido é maior que o valor atual do estoque
                    {
                        lblNotificacao.Text = "Alerta:Valor de saída maior que o valor do estoque.\nTente outro valor.";
                        return;
                    }

                    qtdEstoque -= valor; // subtrai e atualiza a quantidade total atual do estoque

                    if (qtdEstoque == 0) // se a quantidade de estoque for zero ele retorna a mensagem abaixo
                    {
                        lblNotificacao.Text = "Alerta:Estoque vazio. Por favor, reabasteça este produto.";
                    }
                    else if (qtdEstoque < LIMITE) // se a quantidade de estoque for menor que o LIMITE (5) retorna a mensagem abaixo
                    {
                        lblNotificacao.Text = "Alerta: Baixo estoque.Por favor, reabasteça este produto.";
                    }
                    else 
                        lblNotificacao.Text = "Estoque suficiente";

                    lblQtd.Text = qtdEstoque.ToString();
                }

               else // se o número for 0 ou negativo
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

                if (valor > 0) // verifica se o valor inserido pelo o usuário é um valor positivo maior do que zero
                {
                    qtdEstoque += valor; // soma e atualiza a quantidade total atual do estoque

                    lblQtd.Text = qtdEstoque.ToString(); // atualiza o total do estoque que é mostrado para o usuário

                    if (qtdEstoque >= LIMITE) // notifica ao usuário a quantia de produto que recebeu entrada
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
