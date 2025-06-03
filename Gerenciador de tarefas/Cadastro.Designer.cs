namespace Gerenciador_de_tarefas
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 89);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 175);
            label2.Name = "label2";
            label2.Size = new Size(79, 27);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 243);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(169, 351);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(160, 34);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(393, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(169, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 35);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 35);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(169, 273);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 35);
            txtSenha.TabIndex = 7;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(517, 540);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosed += Cadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCadastrar;
        private Button btnVoltar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
    }
}