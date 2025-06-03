using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_tarefas
{
    class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }  
        public string Nome { 
            get { return nome; } 
            set { nome = value; } 
        }
        public string Email { 
            get { return email; } 
            set { email = value; }
        }
        public string Senha { 
            get { return senha; } 
            set { senha = value; }
        }

        public void cadastrarUsuario()
        {
            try {

                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {

                    string query = "INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha)";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", Nome);
                        comando.Parameters.AddWithValue("@email", Email);
                        comando.Parameters.AddWithValue("@senha", Senha);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            Console.WriteLine("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao cadastrar usuário.");
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
            }
        }
    }
}
