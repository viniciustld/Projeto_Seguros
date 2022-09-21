using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.login
{
    public partial class CriarLogin : Form
    {
        // gerando conexão com o banco de dados
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public CriarLogin()
        {
            InitializeComponent();
        }

        // botão que cria novo login no sistema

        private void btnCriar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string user = txtUser.Text;
            string pass = txtPass.Text;
            string conf = txtConfirm.Text;

            if (pass != conf)
            {
                MessageBox.Show("Senhas Diferentes!");
            }
            else
            {
                string x = "INSERT INTO funcionario (nome, senha) VALUES ('" + user + "', '" + pass + "');";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos com Sucesso!!!");

                conexao.Close();
                
                this.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtUser.Clear();
                    txtPass.Clear();
                    txtConfirm.Clear();
                }
            }

        }
    }
}
