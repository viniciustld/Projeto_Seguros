using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCliente : Form
    {

        // gerando conexao com o banco de dados

        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";

        public FormcadCliente()
        {
            if (BackColor == System.Drawing.Color.FromArgb(65, 65, 65))
            {
                label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                label2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                label3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                label6.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                label7.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                label8.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                btnSalvar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            }
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            // Validador de credenciais

            string nome = txtNome.Text;
            string rg = txtRg.Text;
            string cpf = txtCPF.Text;
            string end = txtEndereco.Text;
            string num = txtNumero.Text;
            string cep = txtCep.Text;
            if (CpfUtils.IsValid(cpf))
            {
                MessageBox.Show("Cpf Validado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Cpf Inválido, Tente novamente!!!");
                txtCPF.Clear();
                return;
            }

            // verificação de campos chave e execução do comando no banco de dados

            if (nome == "" || rg == "" || cpf == "" || end == "" || num == "" || cep == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "INSERT INTO pessoa (nome, rg, cpf, endereco, numero, cep)" +
                                 "VALUES ('" + nome + "', '" + rg + "', '" + cpf + "'," +
                                 "        '" + end + "', '" + num + "', '" + cep + "');";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();


                MessageBox.Show("Dados Inseridos com Sucesso!!!");

                conexao.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtNome.Clear();
                    txtRg.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtNumero.Clear();
                    txtCep.Clear();
                }
            }
        }

    }
}
