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
            long numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.", "Campo vazio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Interrompe a execução do código caso o campo esteja vazio

            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.", "Campo vazio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 

            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade");
                return;

            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked )
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return; 

            }

            // Agora, caso todos os campos estejam preenchidos, a validação prossegue
            numeroCadastro = long.Parse(txtNumero.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determinar o gênero selecionado

            string generoSelecionado = "Não informado";

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Não-Binário";



                //Exibir as informações em MessageBox
                MessageBox.Show($"Número cadastrado: {numeroCadastro} \nNome: {nomeUsuario}\nData de Nascimento: {dataFormatada}\nGênero: {generoSelecionado}\nCidade: {cidade}");
            /*MessageBox.Show($"Nome: {nomeUsuario}");
            MessageBox.Show($"Data de Nascimento: {dataFormatada}");
            MessageBox.Show($"Cidade: {cidade}");*/
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            txtNumero.Clear();
        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
