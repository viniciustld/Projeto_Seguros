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
    }
}
