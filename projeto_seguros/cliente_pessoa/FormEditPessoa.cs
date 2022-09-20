using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormEditPessoa : Form
    {
        // gerando conexão com o banco de dados

        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public FormEditPessoa()
        {
            InitializeComponent();
        }

        // alteração de dados de cliente cadastrados

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string nome = txtNome.Text;
            string end = txtEndereco.Text;
            string num = txtNumero.Text;
            string cep = txtCep.Text;
            string nomeA = txtNomeAlvo.Text;

            if (nome == "" || end == "" || num == "" || cep == "" || nomeA == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "UPDATE pessoa " +
                           "SET " +
                           "    nome = '" + nome + "'," +
                           "    endereco = '" + end + "'," +
                           "    numero = '" + num + "', " +
                           "    cep = '" + cep + "'" +
                           "WHERE " +
                           "    nome = '" + nomeA + "';";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Alterados com Sucesso!!!");

                conexao.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtNomeAlvo.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtNumero.Clear();
                    txtCep.Clear();
                }
            }
        }
    }
}
