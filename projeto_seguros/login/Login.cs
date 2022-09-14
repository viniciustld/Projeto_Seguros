using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MultiColoredModernUI.login;

namespace MultiColoredModernUI.Forms
{
    public partial class Login : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";
        public Login()
        {
            InitializeComponent();
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtUser.Text == "" &&
                txtPass.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                MySqlDataReader dr;

                MySqlCommand cmd = new MySqlCommand();
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM funcionario where nome = '" + txtUser.Text + "' AND senha = '" + txtPass.Text + "';";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CriarLogin cl = new CriarLogin();
            cl.Show();
        }
    }
}
