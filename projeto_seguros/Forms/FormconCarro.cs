using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormconCarro : Form
    {
        private MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='2345P@s58942';persistsecurityinfo=True;database=pim";

        public FormconCarro()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection conexao = new(fonte);

            if (txtBuscar.Text != "")
            {
                data002.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MySqlDataAdapter cmd = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string x = "SELECT pessoa.nome, pessoa.cpf, carro.cor, carro.placa, carro.modelo, carro.marca FROM pessoa RIGHT OUTER JOIN carro ON pessoa.cpf = carro.fk_pessoa_cpf WHERE cpf LIKE '%" + txtBuscar.Text + "%';";


                conexao.Open();
                cmd = new MySqlDataAdapter(x, conexao);
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
