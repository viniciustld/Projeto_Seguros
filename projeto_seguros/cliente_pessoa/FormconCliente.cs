using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormconCliente : Form
    {
        // gerando conexão com o banco de dados

        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";
        public FormconCliente()
        {
            InitializeComponent();
            cor();
        }
        private void cor()
        {
            if (BackColor == Color.FromArgb(65, 65, 65))
            {
                data003.BackgroundColor = Color.FromArgb(65, 65, 65);
            }
        }

        // verificação do campo chave e pesquisa de cliente no banco de dados em tempo real
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

                string x = "SELECT * FROM pessoa WHERE nome LIKE '%" + busca + "%';";

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

        // janela de edição de cliente já cadastrados
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            FormEditPessoa ep = new FormEditPessoa();
            ep.Show();
        }

        // evento de exclusão de clientes e carro (caso o cliente tenha veiculos) do banco de dados

        private void data003_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string m = "Tem Certeza que deseja Excluir? ";
            string c = "Excluir";
            MessageBoxButtons b = MessageBoxButtons.YesNo;
            DialogResult r;

            r = MessageBox.Show(m, c, b);
            if (r == DialogResult.Yes)
            {
                MySqlConnection conexao = new(fonte);

                // deletando qualquer veiculo no nome da pessoa

                string info1 = data003.Rows[e.RowIndex].Cells[2].Value.ToString();

                string y = "DELETE FROM carro WHERE fk_pessoa_cpf = '" + info1 + "'";

                MySqlCommand comando1 = new(y, conexao);

                conexao.Open();

                comando1.ExecuteReader();


                conexao.Close();

                // deletando a pessoa

                string info = data003.Rows[e.RowIndex].Cells[0].Value.ToString();

                string x = "DELETE FROM pessoa WHERE nome = '" + info + "'";

                MySqlCommand comando = new(x, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cliente Deletado Com Sucesso!!!");

                conexao.Close();
            }


        }
    }
}
