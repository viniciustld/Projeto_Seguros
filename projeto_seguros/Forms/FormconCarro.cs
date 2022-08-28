using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormconCarro : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog=seguros;Integrated Security=True";

        public FormconCarro()
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
                data002.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                SqlDataAdapter cmd = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT * FROM carro WHERE cpf LIKE '%" + txtBuscar.Text + "%';";

                conexao.Open();
                cmd = new SqlDataAdapter(x, conexao);
                cmd.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                data002.DataSource = dv;
                conexao.Close();
            }
            else if (txtBuscar.Text == "")
            {
                data002.Refresh();
            }

        }
    }


}
