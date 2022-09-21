using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiColoredModernUI.Forms
{
    public partial class FormaciSeguro : Form
    {
        // gerando conexão com o bando de dados

        MySqlConnection conexao;

        private string fonte = "server=127.0.0.1;user id=root;password='123vin@';persistsecurityinfo=True;database=pim";

        public FormaciSeguro()
        {
            InitializeComponent();
        }

        // evento de pesquisar carros cadastrados no cpf de X pessoa

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

        // abrir janela de registrar ocorrencia
        private void btnAcionar_Click(object sender, EventArgs e)
        {
            AcionarSeguro acionar = new AcionarSeguro();
            acionar.Show();
        }
    }
}
