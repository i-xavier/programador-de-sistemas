using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoDeNumeros
{
    public partial class frmJogoNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpiteDoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoNumeros()
        {
            InitializeComponent();
        }

        private void frmJogoNumeros_Load(object sender, EventArgs e)
        {
            Random ramdom = new Random();
            randomNumber = ramdom.Next(1, 101); //número aleatório entre 1 e 100
        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {

            if (jogoGanho)
            {
                txtResultado.Text = "Você já acertou o número! Reinicie o jogo para jogra novamente!";
                return;
            }

            // Veridica se o número de tentativas chegou a 0
            if (numeroTentativas == 1)
            {
                lblNumerosTentativas.Text = "0";
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou";
                return;
            }

            if(!int.TryParse(txtNumeroInserido.Text, out palpiteDoJogador) || palpiteDoJogador < 1 || palpiteDoJogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100";
                return;

            }

            numeroTentativas--;
            lblNumerosTentativas.Text = numeroTentativas.ToString();

            if (palpiteDoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabéns, você acertou!";
            
            }
            else if (palpiteDoJogador < randomNumber) 
            {

                dica = "Digite um número maior";

            }
            else
            {

                dica = "Digite um número menor";
            }

            txtResultado.Text = dica;
        }
    }
}
