using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_tarefas
{
    class ConexaoDB
    {
        private string conexao = "Server=localhost;Database=contatos;Uid=root;Pwd=;";

        public MySqlConnection Conectar()
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                Console.WriteLine("Conexão estabelecida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }
            return conn;
        }
    }
}
