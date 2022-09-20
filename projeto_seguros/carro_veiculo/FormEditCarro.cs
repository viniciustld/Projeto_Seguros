using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormEditCarro : Form
    {
        // gerando conexão com o banco de dados

        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public FormEditCarro()
        {
            InitializeComponent();
        }

        // evento de validação e armazenamento de dados dos veículos alterados no banco de dados

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string cor = txtCor.Text;
            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string placaA = txtPlacaAlvo.Text;

            // validação da placa

            Regex pm = new Regex(@"\b[A-Z]{3}[0-9][A-Z][0-9]{2}\b", RegexOptions.IgnoreCase);
            Regex pa = new Regex(@"\b[A-Z]{3}[0-9]{4}\b", RegexOptions.IgnoreCase);

            if (!pa.IsMatch(placa) && !pm.IsMatch(placa))
            {
                MessageBox.Show("Placa do Veículo Inválida, Tente Novamente!!!");
                txtPlaca.Clear();
            }
            else
            {
                MessageBox.Show("Placa Validada com Sucesso!!!");
            }

            // alteração dos dados

            if (cor == "" || placa == "" || modelo == "" || marca == "" || placaA == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string x = "UPDATE carro " +
                           "SET " +
                           "    cor = '" + cor + "'," +
                           "    placa = '" + placa + "'," +
                           "    modelo = '" + modelo + "', " +
                           "    marca = '" + marca + "'" +
                           "WHERE " +
                           "    placa = '" + placaA + "';";

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

                this.Close();

            }
        }
    }
}
