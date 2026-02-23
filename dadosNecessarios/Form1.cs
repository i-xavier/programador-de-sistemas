using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosNecessarios
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //Validação de campos obrigatórios
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.", "Campo vazio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Interrompe a execução do código caso o campo esteja vazio

            }

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.", "Campo vazio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Interrompe a execução do código caso o campo esteja vazio

            }
        }
    }
}
