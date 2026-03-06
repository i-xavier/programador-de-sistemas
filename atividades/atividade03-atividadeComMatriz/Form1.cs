using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeMatriz
{
    public partial class frmJogo : Form
    {
        private int[,] matriz = new int[7, 7];
        int x, y, pontuacao;
        Random rnd = new Random();


        public frmJogo()
        {
            InitializeComponent();
            iniciarJogo();

        }

        public void iniciarJogo()
        {
            pontuacao = 0;
            int valor = 1;
            x = rnd.Next(0, 7);
            y = rnd.Next(0, 7);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matriz[i,j] = valor++;

                }
            }

            MessageBox.Show(matriz[x, y].ToString());

        }
       

        public bool validarPalpite(int valor)
        {
            return valor == matriz[x, y];
        }



        private void enviarPalpite(object sender, MouseEventArgs e)
        {
            int valor;

            Button botaoClicado = sender as Button;

            if (botaoClicado == null)
                return;

            
            int.TryParse(botaoClicado.Text, out valor);

            bool acertou = validarPalpite(valor);

            if (acertou)
            {
                MessageBox.Show("Você acertou");
                pontuacao++;
                lblPontos.Text = pontuacao.ToString();

                DialogResult dialogResult = MessageBox.Show(
                    "Deseja começar um novo jogo?",
                    "",
                    MessageBoxButtons.YesNo
                );

                if (dialogResult == DialogResult.Yes)
                {
                    int aux = pontuacao;
                    iniciarJogo();
                    pontuacao = aux;
                }
                else
                {
                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Errado!\nTente outra vez!");

                /*botaoClicado.UseVisualStyleBackColor = false;
                botaoClicado.BackColor = Color.Gray;*/
            }
        }
    }
}
