using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MultiColoredModernUI.login;

namespace MultiColoredModernUI.Forms
{
    public partial class Login : Form
    {
        // gerando conexão com o banco de dados
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public Login()
        {
            InitializeComponent();
        }

        // evento de verificação de usuário e login no sistema
        private void Logar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                MySqlDataReader dr;

                MySqlCommand cmd = new MySqlCommand();
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM funcionario where nome = '" + user + "' AND senha = '" + pass + "';";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // mensagem de login com sucesso
                    DialogResult m = MessageBox.Show("Logado Com Sucesso!!!", "", MessageBoxButtons.OK);
                    if (m == DialogResult.OK)
                    {
                        this.Close();
                    }
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciais Incorretas, Tente Novamente!");
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                    }
                }
                conexao.Close();
            }

        }

        // botão para gerar janela de criação de novo login

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CriarLogin cl = new CriarLogin();
            cl.Show();
        }
    }
}
