using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{

    public partial class FormEditCarro : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";
        public FormEditCarro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtCor.Text == "" &&
                txtPlaca.Text == "" &&
                txtModelo.Text == "" &&
                txtMarca.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "UPDATE carro " +
                           "SET " +
                           "    cor = '" + txtCor.Text + "'," +
                           "    placa = '" + txtPlaca.Text + "'," +
                           "    modelo = '" + txtModelo.Text + "', " +
                           "    marca = '" + txtMarca.Text + "'" +
                           "WHERE " +
                           "    placa = '" + txtPlacaAlvo.Text + "';";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Alterados com Sucesso!!!");

                conexao.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtPlacaAlvo.Clear();
                    txtCor.Clear();
                    txtPlaca.Clear();
                    txtModelo.Clear();
                    txtMarca.Clear();
                }

            }
        }
    }
}
