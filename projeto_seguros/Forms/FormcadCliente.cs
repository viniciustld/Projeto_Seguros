using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCliente : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog=seguros;Integrated Security=True";

        public FormcadCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new(fonte);

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

                SqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos com Sucesso!!!");

                conexao.Close();
            }
        }
    }
}
