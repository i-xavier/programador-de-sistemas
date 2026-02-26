using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade02_diaDaSemana
{
    public partial class frmFundo : Form
    {
        public frmFundo()
        {
            InitializeComponent();
        }

        private void Enviar(object sender, EventArgs e)
        {

            try 
            {
                int codigo = Convert.ToInt16(textBox1.Text);
                lblResultado.Text = getDiaDaSemana(codigo);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private string getDiaDaSemana (int codigo)
        {
            string result = "";

            switch (codigo)
            {
                case 1: result = "Domingo"; break;
                case 2: result = "Segunda-Feira"; break;
                case 3: result = "Terça-Feira"; break;
                case 4: result = "Quarta-Feira"; break;
                case 5: result = "Quinta-Feira"; break;
                case 6: result = "Sexta-Feira"; break;
                case 7: result = "Sábado"; break;
            }

            return result;
        }
    }
}
