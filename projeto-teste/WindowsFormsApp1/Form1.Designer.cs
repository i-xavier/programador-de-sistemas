namespace WindowsFormsApp1
{
    partial class frmCalculadoraFundo
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
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btnTeclaSubtracao = new System.Windows.Forms.Button();
            this.btnTeclaDivisao = new System.Windows.Forms.Button();
            this.btnTeclaMultiplicacao = new System.Windows.Forms.Button();
            this.btnTeclaParenteseE = new System.Windows.Forms.Button();
            this.btnTecla9 = new System.Windows.Forms.Button();
            this.btnTecla8 = new System.Windows.Forms.Button();
            this.btnTecla7 = new System.Windows.Forms.Button();
            this.btnTeclaParenteseD = new System.Windows.Forms.Button();
            this.btnTecla6 = new System.Windows.Forms.Button();
            this.btnTecla5 = new System.Windows.Forms.Button();
            this.btnTecla4 = new System.Windows.Forms.Button();
            this.btnTeclaIgual = new System.Windows.Forms.Button();
            this.btnTecla3 = new System.Windows.Forms.Button();
            this.btnTecla2 = new System.Windows.Forms.Button();
            this.btnTecla1 = new System.Windows.Forms.Button();
            this.btnTeclaPonto = new System.Windows.Forms.Button();
            this.btnTecla0 = new System.Windows.Forms.Button();
            this.btnTeclaCE = new System.Windows.Forms.Button();
            this.btnTeclaSoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTela
            // 
            this.txtTela.Enabled = false;
            this.txtTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTela.Location = new System.Drawing.Point(13, 12);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(258, 47);
            this.txtTela.TabIndex = 0;
            // 
            // btnTeclaSubtracao
            // 
            this.btnTeclaSubtracao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaSubtracao.Location = new System.Drawing.Point(78, 75);
            this.btnTeclaSubtracao.Name = "btnTeclaSubtracao";
            this.btnTeclaSubtracao.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaSubtracao.TabIndex = 3;
            this.btnTeclaSubtracao.Text = "-";
            this.btnTeclaSubtracao.UseVisualStyleBackColor = true;
            this.btnTeclaSubtracao.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaDivisao
            // 
            this.btnTeclaDivisao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaDivisao.Location = new System.Drawing.Point(144, 75);
            this.btnTeclaDivisao.Name = "btnTeclaDivisao";
            this.btnTeclaDivisao.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaDivisao.TabIndex = 4;
            this.btnTeclaDivisao.Text = "/";
            this.btnTeclaDivisao.UseVisualStyleBackColor = true;
            this.btnTeclaDivisao.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaMultiplicacao
            // 
            this.btnTeclaMultiplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaMultiplicacao.Location = new System.Drawing.Point(210, 75);
            this.btnTeclaMultiplicacao.Name = "btnTeclaMultiplicacao";
            this.btnTeclaMultiplicacao.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaMultiplicacao.TabIndex = 5;
            this.btnTeclaMultiplicacao.Text = "*";
            this.btnTeclaMultiplicacao.UseVisualStyleBackColor = true;
            this.btnTeclaMultiplicacao.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaParenteseE
            // 
            this.btnTeclaParenteseE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaParenteseE.Location = new System.Drawing.Point(210, 141);
            this.btnTeclaParenteseE.Name = "btnTeclaParenteseE";
            this.btnTeclaParenteseE.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaParenteseE.TabIndex = 10;
            this.btnTeclaParenteseE.Text = "(";
            this.btnTeclaParenteseE.UseVisualStyleBackColor = true;
            this.btnTeclaParenteseE.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla9
            // 
            this.btnTecla9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla9.Location = new System.Drawing.Point(144, 141);
            this.btnTecla9.Name = "btnTecla9";
            this.btnTecla9.Size = new System.Drawing.Size(60, 60);
            this.btnTecla9.TabIndex = 9;
            this.btnTecla9.Text = "9";
            this.btnTecla9.UseVisualStyleBackColor = true;
            this.btnTecla9.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla8
            // 
            this.btnTecla8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla8.Location = new System.Drawing.Point(78, 141);
            this.btnTecla8.Name = "btnTecla8";
            this.btnTecla8.Size = new System.Drawing.Size(60, 60);
            this.btnTecla8.TabIndex = 8;
            this.btnTecla8.Text = "8";
            this.btnTecla8.UseVisualStyleBackColor = true;
            this.btnTecla8.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla7
            // 
            this.btnTecla7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla7.Location = new System.Drawing.Point(12, 141);
            this.btnTecla7.Name = "btnTecla7";
            this.btnTecla7.Size = new System.Drawing.Size(60, 60);
            this.btnTecla7.TabIndex = 7;
            this.btnTecla7.Text = "7";
            this.btnTecla7.UseVisualStyleBackColor = true;
            this.btnTecla7.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaParenteseD
            // 
            this.btnTeclaParenteseD.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaParenteseD.Location = new System.Drawing.Point(210, 207);
            this.btnTeclaParenteseD.Name = "btnTeclaParenteseD";
            this.btnTeclaParenteseD.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaParenteseD.TabIndex = 15;
            this.btnTeclaParenteseD.Text = ")";
            this.btnTeclaParenteseD.UseVisualStyleBackColor = true;
            this.btnTeclaParenteseD.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla6
            // 
            this.btnTecla6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla6.Location = new System.Drawing.Point(144, 207);
            this.btnTecla6.Name = "btnTecla6";
            this.btnTecla6.Size = new System.Drawing.Size(60, 60);
            this.btnTecla6.TabIndex = 14;
            this.btnTecla6.Text = "6";
            this.btnTecla6.UseVisualStyleBackColor = true;
            this.btnTecla6.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla5
            // 
            this.btnTecla5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla5.Location = new System.Drawing.Point(78, 207);
            this.btnTecla5.Name = "btnTecla5";
            this.btnTecla5.Size = new System.Drawing.Size(60, 60);
            this.btnTecla5.TabIndex = 13;
            this.btnTecla5.Text = "5";
            this.btnTecla5.UseVisualStyleBackColor = true;
            this.btnTecla5.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla4
            // 
            this.btnTecla4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla4.Location = new System.Drawing.Point(12, 207);
            this.btnTecla4.Name = "btnTecla4";
            this.btnTecla4.Size = new System.Drawing.Size(60, 60);
            this.btnTecla4.TabIndex = 12;
            this.btnTecla4.Text = "4";
            this.btnTecla4.UseVisualStyleBackColor = true;
            this.btnTecla4.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaIgual
            // 
            this.btnTeclaIgual.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaIgual.Location = new System.Drawing.Point(210, 273);
            this.btnTeclaIgual.Name = "btnTeclaIgual";
            this.btnTeclaIgual.Size = new System.Drawing.Size(60, 126);
            this.btnTeclaIgual.TabIndex = 20;
            this.btnTeclaIgual.Text = "=";
            this.btnTeclaIgual.UseVisualStyleBackColor = true;
            this.btnTeclaIgual.Click += new System.EventHandler(this.Calcular);
            // 
            // btnTecla3
            // 
            this.btnTecla3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla3.Location = new System.Drawing.Point(144, 273);
            this.btnTecla3.Name = "btnTecla3";
            this.btnTecla3.Size = new System.Drawing.Size(60, 60);
            this.btnTecla3.TabIndex = 19;
            this.btnTecla3.Text = "3";
            this.btnTecla3.UseVisualStyleBackColor = true;
            this.btnTecla3.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla2
            // 
            this.btnTecla2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla2.Location = new System.Drawing.Point(78, 273);
            this.btnTecla2.Name = "btnTecla2";
            this.btnTecla2.Size = new System.Drawing.Size(60, 60);
            this.btnTecla2.TabIndex = 18;
            this.btnTecla2.Text = "2";
            this.btnTecla2.UseVisualStyleBackColor = true;
            this.btnTecla2.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla1
            // 
            this.btnTecla1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla1.Location = new System.Drawing.Point(12, 273);
            this.btnTecla1.Name = "btnTecla1";
            this.btnTecla1.Size = new System.Drawing.Size(60, 60);
            this.btnTecla1.TabIndex = 17;
            this.btnTecla1.Text = "1";
            this.btnTecla1.UseVisualStyleBackColor = true;
            this.btnTecla1.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaPonto
            // 
            this.btnTeclaPonto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaPonto.Location = new System.Drawing.Point(144, 339);
            this.btnTeclaPonto.Name = "btnTeclaPonto";
            this.btnTeclaPonto.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaPonto.TabIndex = 24;
            this.btnTeclaPonto.Text = ".";
            this.btnTeclaPonto.UseVisualStyleBackColor = true;
            this.btnTeclaPonto.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTecla0
            // 
            this.btnTecla0.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecla0.Location = new System.Drawing.Point(78, 339);
            this.btnTecla0.Name = "btnTecla0";
            this.btnTecla0.Size = new System.Drawing.Size(60, 60);
            this.btnTecla0.TabIndex = 23;
            this.btnTecla0.Text = "0";
            this.btnTecla0.UseVisualStyleBackColor = true;
            this.btnTecla0.Click += new System.EventHandler(this.EscreverTela);
            // 
            // btnTeclaCE
            // 
            this.btnTeclaCE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaCE.Location = new System.Drawing.Point(12, 339);
            this.btnTeclaCE.Name = "btnTeclaCE";
            this.btnTeclaCE.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaCE.TabIndex = 22;
            this.btnTeclaCE.Text = "CE";
            this.btnTeclaCE.UseVisualStyleBackColor = true;
            this.btnTeclaCE.Click += new System.EventHandler(this.ApagarTela);
            // 
            // btnTeclaSoma
            // 
            this.btnTeclaSoma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaSoma.Location = new System.Drawing.Point(12, 75);
            this.btnTeclaSoma.Name = "btnTeclaSoma";
            this.btnTeclaSoma.Size = new System.Drawing.Size(60, 60);
            this.btnTeclaSoma.TabIndex = 2;
            this.btnTeclaSoma.Text = "+";
            this.btnTeclaSoma.UseVisualStyleBackColor = true;
            this.btnTeclaSoma.Click += new System.EventHandler(this.EscreverTela);
            // 
            // frmCalculadoraFundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 416);
            this.Controls.Add(this.btnTeclaSoma);
            this.Controls.Add(this.btnTeclaPonto);
            this.Controls.Add(this.btnTecla0);
            this.Controls.Add(this.btnTeclaCE);
            this.Controls.Add(this.btnTeclaIgual);
            this.Controls.Add(this.btnTecla3);
            this.Controls.Add(this.btnTecla2);
            this.Controls.Add(this.btnTecla1);
            this.Controls.Add(this.btnTeclaParenteseD);
            this.Controls.Add(this.btnTecla6);
            this.Controls.Add(this.btnTecla5);
            this.Controls.Add(this.btnTecla4);
            this.Controls.Add(this.btnTeclaParenteseE);
            this.Controls.Add(this.btnTecla9);
            this.Controls.Add(this.btnTecla8);
            this.Controls.Add(this.btnTecla7);
            this.Controls.Add(this.btnTeclaMultiplicacao);
            this.Controls.Add(this.btnTeclaDivisao);
            this.Controls.Add(this.btnTeclaSubtracao);
            this.Controls.Add(this.txtTela);
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraFundo";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnTeclaSubtracao;
        private System.Windows.Forms.Button btnTeclaDivisao;
        private System.Windows.Forms.Button btnTeclaMultiplicacao;
        private System.Windows.Forms.Button btnTeclaParenteseE;
        private System.Windows.Forms.Button btnTecla9;
        private System.Windows.Forms.Button btnTecla8;
        private System.Windows.Forms.Button btnTecla7;
        private System.Windows.Forms.Button btnTeclaParenteseD;
        private System.Windows.Forms.Button btnTecla6;
        private System.Windows.Forms.Button btnTecla5;
        private System.Windows.Forms.Button btnTecla4;
        private System.Windows.Forms.Button btnTeclaIgual;
        private System.Windows.Forms.Button btnTecla3;
        private System.Windows.Forms.Button btnTecla2;
        private System.Windows.Forms.Button btnTecla1;
        private System.Windows.Forms.Button btnTeclaPonto;
        private System.Windows.Forms.Button btnTecla0;
        private System.Windows.Forms.Button btnTeclaCE;
        private System.Windows.Forms.Button btnTeclaSoma;
    }
}

