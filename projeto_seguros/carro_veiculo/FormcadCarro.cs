using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCarro : Form
    {
        // gerando conexão com o banco de dados

        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";

        public FormcadCarro()
        {
            InitializeComponent();
        }

        // evento de pesquisa de cliente em tempo real para cadastro de veículos em seu cpf

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string busca = txtBuscar.Text;

            if (busca != "")
            {
                data001.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MySqlDataAdapter cmd = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT nome, rg, cpf from pessoa WHERE nome LIKE '%" + busca + "%';";

                conexao.Open();
                cmd = new MySqlDataAdapter(x, conexao);
                cmd.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                data001.DataSource = dv;
                conexao.Close();
            }
            else if (busca == "")
            {
                data001.Refresh();
            }
            
        }

        // evento de cadastrar veículo no sistema (similar ao cadastro de pessoas)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string cor = txtCor.Text;
            string marca = txtMarca.Text;
            string model = txtModelo.Text;
            string placa = txtPlaca.Text;
            string fk = txtfkcarro.Text;

            // validação da placa do veículo

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

            // validação de campos e cadastro de veículos no sistema pos validação

            if (cor == "" || marca == "" || model == "" || placa == "" || fk == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string q = "INSERT INTO carro (cor, placa, marca, modelo, fk_pessoa_cpf)" +
                            "VALUES ('" + cor + "', '" + placa + "'," +
                            " '" + marca + "', '" + model + "', '" + fk + "')";

                MySqlCommand comando = new(q, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos Com Sucesso!!!");

                conexao.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtCor.Clear();
                    txtPlaca.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtfkcarro.Clear();
                }
            }
        }

        // evento que captura o cpf da pessoa baseando-se onde foi clicado
        private void data001_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string info = data001.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfkcarro.Text = info;
        }
    }
}
