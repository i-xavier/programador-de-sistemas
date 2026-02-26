namespace atividade01
{
    partial class Form1
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(304, 299);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(120, 31);
            this.txtBox.TabIndex = 0;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(347, 97);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(121, 31);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Estoque";
            // 
            // btnSaida
            // 
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Location = new System.Drawing.Point(430, 271);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(101, 34);
            this.btnSaida.TabIndex = 2;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacao.Location = new System.Drawing.Point(199, 216);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(0, 20);
            this.lblNotificacao.TabIndex = 3;
            this.lblNotificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtd
            // 
            this.lblQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(364, 140);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(85, 23);
            this.lblQtd.TabIndex = 4;
            this.lblQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(430, 311);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(101, 32);
            this.btnEntrada.TabIndex = 5;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnEntrada;
    }
}

