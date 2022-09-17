using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormconCliente : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";
        public FormconCliente()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtBuscar.Text != "")
            {
                data003.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MySqlDataAdapter cmd = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT * FROM pessoa WHERE nome LIKE '%" + txtBuscar.Text + "%';";

                conexao.Open();
                cmd = new MySqlDataAdapter(x, conexao);
                cmd.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                data003.DataSource = dv;
                conexao.Close();
            }
            else if (txtBuscar.Text == "")
            {
                data003.Refresh();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            FormEditPessoa ep = new FormEditPessoa();
            ep.Show();
        }

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

                string y = "DELETE FROM carro WHERE fk_pessoa_cpf = '"+info1+"'";

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
