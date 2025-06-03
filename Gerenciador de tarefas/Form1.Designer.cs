namespace Gerenciador_de_tarefas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            linkCadastrese = new LinkLabel();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 140);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 223);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // button1
            // 
            button1.Location = new Point(187, 294);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 3;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkCadastrese
            // 
            linkCadastrese.AutoSize = true;
            linkCadastrese.Location = new Point(177, 382);
            linkCadastrese.Name = "linkCadastrese";
            linkCadastrese.Size = new Size(142, 27);
            linkCadastrese.TabIndex = 4;
            linkCadastrese.TabStop = true;
            linkCadastrese.Text = "Cadastre-se";
            linkCadastrese.LinkClicked += linkCadastrese_LinkClicked;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 35);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 35);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(161, 253);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(191, 35);
            txtSenha.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(517, 540);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(linkCadastrese);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private LinkLabel linkCadastrese;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
    }
}
