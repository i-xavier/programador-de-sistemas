using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class frmPictureBox : Form
    {
        private string ImagemLocalizada;
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void VerImagem(object sender, EventArgs e)
        {
            pBCidade.Image = Image.FromFile(@"C:\Users\igor.xsantos1\Downloads\saopaulo.jpg");
            pBCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                // caixa de diálogo para abrir arquivo.
                OpenFileDialog abrirArquivo = new OpenFileDialog();
                abrirArquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (abrirArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    ImagemLocalizada = abrirArquivo.FileName;

                    pBAnexarImagem.ImageLocation = ImagemLocalizada;
                    pBAnexarImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
