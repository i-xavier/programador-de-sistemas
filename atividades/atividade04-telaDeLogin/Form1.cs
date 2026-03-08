using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade04_telaDeLogin
{
    public partial class frmLogin : Form
    {
        String emailCorreto = "123";
        String senhaCorreta = "123";
        int tentativas = 0;
        int maxTentativas = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Logar(object sender, MouseEventArgs e)
        {
            if (tentativas >= maxTentativas)
            {
                MessageBox.Show("Sua conta está bloqueada!.", "Erro");
                btnLogar.Enabled = false;
                return;
            }


            if (txtUsuario.Text == emailCorreto && txtSenha.Text == senhaCorreta)
            {
                MessageBox.Show("Bem-vindo!");
            }

            else
            {   
                while(tentativas < maxTentativas)
                {
                    MessageBox.Show("Senha incorreta. Você tem mais " + (maxTentativas - ++tentativas) + "tentativa.");
                    break;
                }
            }

            if (tentativas == maxTentativas)
            {
                MessageBox.Show("Sua conta foi bloqueada!.", "Erro");
                btnLogar.Enabled = false;
            }


        }


    }
}
