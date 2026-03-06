namespace atividade04_telaDeLogin
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitulo.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitulo.Location = new System.Drawing.Point(345, 133);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(110, 42);
            this.lblLoginTitulo.TabIndex = 0;
            this.lblLoginTitulo.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(350, 215);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(350, 261);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelFundo.Controls.Add(this.btnLogar);
            this.panelFundo.Controls.Add(this.lblSenha);
            this.panelFundo.Controls.Add(this.lblUsuario);
            this.panelFundo.Controls.Add(this.txtSenha);
            this.panelFundo.Controls.Add(this.panelBot);
            this.panelFundo.Controls.Add(this.txtUsuario);
            this.panelFundo.Controls.Add(this.panelTop);
            this.panelFundo.Controls.Add(this.lblLoginTitulo);
            this.panelFundo.Controls.Add(this.panelRight);
            this.panelFundo.Controls.Add(this.panelLeft);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 450);
            this.panelFundo.TabIndex = 3;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(363, 301);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Logar);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(283, 261);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(281, 215);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "usuário:";
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(200, 350);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(400, 100);
            this.panelBot.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 100);
            this.panelTop.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(600, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 450);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFundo);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnLogar;
    }
}

