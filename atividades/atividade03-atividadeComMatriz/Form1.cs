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


        public frmJogo()
        {
            InitializeComponent();
            iniciarJogo();

        }

        public int iniciarJogo()
        {
            pontuacao = 0;
            int valor = 0;
            Random rnd = new Random();
            x = rnd.Next(0, 6);
            y = rnd.Next(0, 6);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matriz[i,j] = valor++;
                }
            }

            MessageBox.Show(matriz[x, y].ToString());
            return matriz[x,y];

        }
        public void acertouBola()
        {
            x = 0;
            y = 0;

            return;
        }


        public Boolean validarBola(int valor)
        {
            Boolean acertou = false;
            

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if(valor == matriz[x, y])
                    {
                        acertou = true;
                        acertouBola();
                    }
                }
            }

            return acertou;
        }

        private void enviarPalpite(object sender, MouseEventArgs e)
        {
            int valor;
            Boolean acertou = false;
            Button botaoClicado = sender as Button;

            try
            {
                int.TryParse(botaoClicado.Text, out valor);
                acertou = validarBola(valor);

                if (acertou)
                {
                    MessageBox.Show("Você acertou");
                    pontuacao++;
                    lblPontos.Text = pontuacao.ToString();

                    DialogResult dialogResult = MessageBox.Show("Deseja começar um novo jogo?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int aux = pontuacao;
                        iniciarJogo();
                        pontuacao = aux;

                    }

                    else
                    {

                    }
                }

                else
                    MessageBox.Show("Errado!\nTente outra vez!");


            }
            catch (Exception ex)
            { 
            
            }
            
            
        }
    }
}
