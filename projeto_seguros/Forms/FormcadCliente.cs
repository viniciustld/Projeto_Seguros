using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCliente : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";

        public FormcadCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtNome.Text == "" &&
                txtCPF.Text == "" &&
                txtRg.Text == "" &&
                txtEndereco.Text == "" &&
                txtNumero.Text == "" &&
                txtCep.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "INSERT INTO pessoa (nome, rg, cpf, endereco, numero, cep)" +
                                 "VALUES ('" + txtNome.Text + "', '" + txtRg.Text + "', '" + txtCPF.Text + "'," +
                                 "        '" + txtEndereco.Text + "', '" + txtNumero.Text + "', '" + txtCep.Text + "');";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos com Sucesso!!!");

                conexao.Close();
            }
        }
    }
}
