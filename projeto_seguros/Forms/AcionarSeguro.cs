using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class AcionarSeguro : Form
    {
        // gerando conexão com o banco de dados

        MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public AcionarSeguro()
        {
            InitializeComponent();
        }

        // evento de registrar a ocorrencia no banco de dados
        private void btnAcionar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string cod = txtcdOcorrencia.Text;
            string desc = txtDescricao.Text;
            string city = txtCidade.Text;
            string bairro = txtBairro.Text;
            string rua = txtRua.Text;
            string fkcar = txtfk_carro_placa.Text;

            // verificação dos campos e insersão das informações

            if (cod == "" || desc == "" || city == "" || bairro == "" || rua == "" || fkcar == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string q = "INSERT INTO ocorrencia (codOcorrencia, descricao, cidade, bairro, rua, fk_carro_placa) VALUES ('" + cod + "', '" + desc + "', '" + city + "', '" + bairro + "', '" + rua + "', '" + fkcar + "')";

                MySqlCommand comando = new(q, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos Com Sucesso!!!");

                conexao.Close();

                // limpeza dos campos de texto pós cadastro
                {
                    txtcdOcorrencia.Clear();
                    txtDescricao.Clear();
                    txtCidade.Clear();
                    txtBairro.Clear();
                    txtRua.Clear();
                    txtfk_carro_placa.Clear();
                }
            }
        }

        // area de pesquisa do cliente para registrar ocorrencia na placa do veiculo de X pessoa

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            string busca = txtBuscar.Text;

            if (busca != "")
            {
                data003.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MySqlDataAdapter cmd = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT pessoa.nome, pessoa.cpf, carro.cor, carro.placa, carro.modelo, carro.marca FROM pessoa RIGHT OUTER JOIN carro ON pessoa.cpf = carro.fk_pessoa_cpf WHERE cpf LIKE '%" + busca + "%';";

                conexao.Open();
                cmd = new MySqlDataAdapter(x, conexao);
                cmd.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                data003.DataSource = dv;
                conexao.Close();
            }
            else if (busca == "")
            {
                data003.Refresh();
            }
        }

        // evento de pegar informação relacionada ao clique do mouse

        private void data003_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string info = data003.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtfk_carro_placa.Text = info;
        }
    }
}
