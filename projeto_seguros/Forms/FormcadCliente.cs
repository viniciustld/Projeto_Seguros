using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormcadCliente : Form
    {
        private SqlConnection conexao;

        private string fonte = "Data Source=DESKTOP-6B9J46M;Initial Catalog = seg_pessoas; Integrated Security = True";

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new(fonte);

            string comando = "INSERT INTO pessoa (nome, rg, cpf, endereco, numero, cep)" +
                             "VALUES ('"+txtNome+"', '"+txtRg+"', '"+txtCPF+"'," +
                             "        '"+txtEndereco+"', '"+txtNumero+"', '"+txtCep+"'";
        }
    }
}
