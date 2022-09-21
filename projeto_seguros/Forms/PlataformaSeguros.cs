using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiColoredModernUI
{
    // classe principal
    public partial class PlataformaSeguros : Form
    {
        //Fields
        private Button currentButton;
        private readonly Random random;
        private readonly int tempIndex;
        private Form activateForm;

        //Contructor
        public PlataformaSeguros()
        {
            InitializeComponent();
            random = new Random();
            BtnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods

        // evento que abre a janela especifica no campo delimitado dentro da janela principal
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            //activateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktopPane.Controls.Add(childForm);
            this.PanelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        // eventos de abertura da janela especifica
        private void CadCliente_Cclick(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormcadCliente(), sender);
            BtnCloseChildForm.Show();
        }

        private void ConCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormconCliente(), sender);
            BtnCloseChildForm.Show();
        }

        private void CadCarro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormcadCarro(), sender);
            BtnCloseChildForm.Show();
        }

        private void ConCarro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormconCarro(), sender);
            BtnCloseChildForm.Show();
        }

        private void AciSeguro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormaciSeguro(), sender);
            BtnCloseChildForm.Show();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConfiguracoes(), sender);
            BtnCloseChildForm.Show();
        }

        // botão que encerra a janela aberta e retorna ao menu principal
        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            BtnCloseChildForm.BackColor = Color.FromArgb(0, 110, 136);
            if (activateForm != null)
                activateForm.Close();
            Reset();

        }

        // evento que retorna tudo ao inicio
        private void Reset()
        {
            lblTitle.Text = "Menu Principal";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelTitleBar.BackColor = Color.FromArgb(0, 110, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            BtnCloseChildForm.Visible = false;

        }

        // eventos de arrastar a janela com o mouse e botões de organização de janela personalizados
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
