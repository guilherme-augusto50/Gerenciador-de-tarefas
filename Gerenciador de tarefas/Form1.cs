namespace Gerenciador_de_tarefas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkCadastrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
    }
}
