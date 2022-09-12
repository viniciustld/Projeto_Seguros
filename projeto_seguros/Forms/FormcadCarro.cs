using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCarro : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";

        public FormcadCarro()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtBuscar.Text != "")
            {
                data001.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MySqlDataAdapter cmd = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT nome, rg, cpf from pessoa WHERE nome LIKE '%" + txtBuscar.Text + "%';";

                conexao.Open();
                cmd = new MySqlDataAdapter(x, conexao);
                cmd.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                data001.DataSource = dv;
                conexao.Close();
            }
            else if (txtBuscar.Text == "")
            {
                data001.Refresh();
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtCor.Text == "" && 
                txtMarca.Text == "" &&
                txtModelo.Text == "" &&
                txtPlaca.Text == "" &&
                txtfkcarro.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string q = "INSERT INTO carro (cor, placa, marca, modelo, fk_pessoa_cpf)" +
                            "VALUES ('" + txtCor.Text + "', '" + txtPlaca.Text + "'," +
                            " '" + txtMarca.Text + "', '" + txtModelo.Text + "', '" + txtfkcarro.Text + "')";

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

        private void data001_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string info = data001.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfkcarro.Text = info;
        }
    }
}
