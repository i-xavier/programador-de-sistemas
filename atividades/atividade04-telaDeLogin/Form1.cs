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
        Boolean logado = false;
        int i = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Logar(object sender, MouseEventArgs e)
        {

            validarLogin(txtUsuario.Text, txtSenha.Text);

            if (logado == true)
            {
                MessageBox.Show("Bem-vindo!");
            }
            else
            {   
                while(i < 3)
                {
                    i++;
                    MessageBox.Show("Senha incorreta. Você tem mais " + (3 - i) + "tentativa.");
                    break;
                }
            }

            

            if (i == 3)
            {
                MessageBox.Show("Sua conta foi bloqueada!.", "Erro");
                btnLogar.Enabled = false;
            }


        }

        private void validarLogin(String user, String senha)
        {
            if (user == emailCorreto && senha == senhaCorreta)
            {
                logado = true;
            }
        }

    }
}
