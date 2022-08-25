using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCliente : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog=seguros;Integrated Security=True";

        public FormcadCliente()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new(fonte);

            string x = "INSERT INTO pessoa (nome, rg, cpf, endereco, numero, cep)" +
                             "VALUES ('"+txtNome.Text +"', '"+txtRg.Text+"', '"+txtCPF.Text+"'," +
                             "        '"+txtEndereco.Text+"', '"+txtNumero.Text+"', '"+txtCep.Text+"')";

            SqlCommand comando = new(x, conexao);

            conexao.Open();

            comando.ExecuteReader();

            MessageBox.Show("Dados Inseridos com Sucesso!!");

            conexao.Close();
        }
    }
}
