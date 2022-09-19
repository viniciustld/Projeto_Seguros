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
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public FormEditPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtNome.Text == "" &&
                txtEndereco.Text == "" &&
                txtNumero.Text == "" &&
                txtCep.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "UPDATE pessoa " +
                           "SET " +
                           "    nome = '" + txtNome.Text + "'," +
                           "    endereco = '" + txtEndereco.Text + "'," +
                           "    numero = '" + txtNumero.Text + "', " +
                           "    cep = '" + txtCep.Text + "'" +
                           "WHERE " +
                           "    nome = '" + txtNomeAlvo.Text + "';";

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
