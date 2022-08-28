using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormconCliente : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog=seguros;Integrated Security=True";
        public FormconCliente()
        {
            InitializeComponent();
            LoadTheme();
        }
        public void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection conexao = new(fonte);

            if (txtBuscar.Text != "")
            {
                data003.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                SqlDataAdapter cmd = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT * FROM pessoa WHERE nome LIKE '%" + txtBuscar.Text + "%';";

                conexao.Open();
                cmd = new SqlDataAdapter(x, conexao);
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
