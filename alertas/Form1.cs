using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class Alertas : Form
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada um no seu quadrado", "Ado ado ado");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?",
                                                    "Título aqui", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Seja Bem-vindo futuro programador!");
            }
            else { 
                MessageBox.Show("Que pena...\nEntão nos vemos por aí!");
            }
            
        }
    }
}
