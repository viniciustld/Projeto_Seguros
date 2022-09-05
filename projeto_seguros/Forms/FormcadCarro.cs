using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCarro : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog=seguros;Integrated Security=True";

        public FormcadCarro()
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
                data001.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                SqlDataAdapter cmd = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT * from carro WHERE nome LIKE '%" + txtBuscar.Text + "%';";

                conexao.Open();
                cmd = new SqlDataAdapter(x, conexao);
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
            SqlConnection conexao = new(fonte);

            if (txtCor.Text == "" && 
                txtMarca.Text == "" &&
                txtModelo.Text == "" &&
                txtPlaca.Text == "" &&
                txtcpfCarro.Text == "")
            {
                MessageBox.Show("Insira os dados Corretamente");
            }
            else
            {
                string q = "INSERT INTO carro (cor, placa, marca, modelo, cpf)" +
            "VALUES ('" + txtCor.Text + "'," + "'" + txtPlaca.Text + "'," +
            " '" + txtMarca.Text + "', '" + txtModelo.Text + "', '" + txtcpfCarro.Text + "');";

                SqlCommand comando = new(q, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Dados Inseridos Com Sucesso!!!");

                conexao.Close();
            }
        }
    }
}
