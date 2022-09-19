using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.login
{
    public partial class CriarLogin : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public CriarLogin()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtConfirm.Text != txtPass.Text)
            {
                MessageBox.Show("Senhas Diferentes!");
            }
            else
            {
                string x = "INSERT INTO funcionario (nome, senha) VALUES ('" + txtUser.Text + "', '" + txtPass.Text + "');";

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
