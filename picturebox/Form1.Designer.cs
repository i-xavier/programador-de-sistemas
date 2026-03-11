namespace picturebox
{
    partial class frmPictureBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pBComputador = new System.Windows.Forms.PictureBox();
            this.pBCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.pBAnexarImagem = new System.Windows.Forms.PictureBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pBComputador
            // 
            this.pBComputador.Image = ((System.Drawing.Image)(resources.GetObject("pBComputador.Image")));
            this.pBComputador.Location = new System.Drawing.Point(80, 49);
            this.pBComputador.Name = "pBComputador";
            this.pBComputador.Size = new System.Drawing.Size(300, 100);
            this.pBComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBComputador.TabIndex = 0;
            this.pBComputador.TabStop = false;
            // 
            // pBCidade
            // 
            this.pBCidade.Location = new System.Drawing.Point(80, 172);
            this.pBCidade.Name = "pBCidade";
            this.pBCidade.Size = new System.Drawing.Size(300, 100);
            this.pBCidade.TabIndex = 1;
            this.pBCidade.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImagem.ForeColor = System.Drawing.Color.White;
            this.btnVerImagem.Location = new System.Drawing.Point(198, 333);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(157, 26);
            this.btnVerImagem.TabIndex = 2;
            this.btnVerImagem.Text = "Ver imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.VerImagem);
            // 
            // pBAnexarImagem
            // 
            this.pBAnexarImagem.Location = new System.Drawing.Point(436, 49);
            this.pBAnexarImagem.Name = "pBAnexarImagem";
            this.pBAnexarImagem.Size = new System.Drawing.Size(207, 223);
            this.pBAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBAnexarImagem.TabIndex = 3;
            this.pBAnexarImagem.TabStop = false;
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.Gold;
            this.btnAnexar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexar.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.Color.Red;
            this.btnAnexar.Location = new System.Drawing.Point(472, 315);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(135, 44);
            this.btnAnexar.TabIndex = 4;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.pBAnexarImagem);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pBCidade);
            this.Controls.Add(this.pBComputador);
            this.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pBComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBComputador;
        private System.Windows.Forms.PictureBox pBCidade;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.PictureBox pBAnexarImagem;
        private System.Windows.Forms.Button btnAnexar;
    }
}

