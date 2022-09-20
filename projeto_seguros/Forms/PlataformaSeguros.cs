using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiColoredModernUI
{
    public partial class PlataformaSeguros : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        //Contructor
        public PlataformaSeguros()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods

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
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void cadCliente_Cclick(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormcadCliente(), sender);
        }

        private void conCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormconCliente(), sender);
        }

        private void cadCarro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormcadCarro(), sender);
        }

        private void conCarro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormconCarro(), sender);
        }

        private void aciSeguro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormaciSeguro(), sender);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConfiguracoes(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();

        }

        private void Reset()
        {
            lblTitle.Text = "Menu Principal";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
