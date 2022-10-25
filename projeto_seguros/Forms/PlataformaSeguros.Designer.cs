
namespace MultiColoredModernUI
{
    partial class PlataformaSeguros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlataformaSeguros));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.AciSeguro = new System.Windows.Forms.Button();
            this.ConCarro = new System.Windows.Forms.Button();
            this.CadCarro = new System.Windows.Forms.Button();
            this.ConCliente = new System.Windows.Forms.Button();
            this.CadCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.BtnMinimized = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelDesktopPane = new System.Windows.Forms.Panel();
            this.BtnOut = new System.Windows.Forms.Button();
            this.BtnLight = new System.Windows.Forms.Button();
            this.BtnDark = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.PanelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.AciSeguro);
            this.panelMenu.Controls.Add(this.ConCarro);
            this.panelMenu.Controls.Add(this.CadCarro);
            this.panelMenu.Controls.Add(this.ConCliente);
            this.panelMenu.Controls.Add(this.CadCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 502);
            this.panelMenu.TabIndex = 0;
            // 
            // AciSeguro
            // 
            this.AciSeguro.Dock = System.Windows.Forms.DockStyle.Top;
            this.AciSeguro.FlatAppearance.BorderSize = 0;
            this.AciSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AciSeguro.ForeColor = System.Drawing.Color.Gainsboro;
            this.AciSeguro.Image = ((System.Drawing.Image)(resources.GetObject("AciSeguro.Image")));
            this.AciSeguro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AciSeguro.Location = new System.Drawing.Point(0, 320);
            this.AciSeguro.Name = "AciSeguro";
            this.AciSeguro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.AciSeguro.Size = new System.Drawing.Size(220, 60);
            this.AciSeguro.TabIndex = 5;
            this.AciSeguro.Text = "  Acionar Seguro";
            this.AciSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AciSeguro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AciSeguro.UseVisualStyleBackColor = true;
            this.AciSeguro.Click += new System.EventHandler(this.AciSeguro_Click);
            // 
            // ConCarro
            // 
            this.ConCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConCarro.FlatAppearance.BorderSize = 0;
            this.ConCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConCarro.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConCarro.Image = ((System.Drawing.Image)(resources.GetObject("ConCarro.Image")));
            this.ConCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConCarro.Location = new System.Drawing.Point(0, 260);
            this.ConCarro.Name = "ConCarro";
            this.ConCarro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ConCarro.Size = new System.Drawing.Size(220, 60);
            this.ConCarro.TabIndex = 4;
            this.ConCarro.Text = "  Consultar Carro";
            this.ConCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConCarro.UseVisualStyleBackColor = true;
            this.ConCarro.Click += new System.EventHandler(this.ConCarro_Click);
            // 
            // CadCarro
            // 
            this.CadCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.CadCarro.FlatAppearance.BorderSize = 0;
            this.CadCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadCarro.ForeColor = System.Drawing.Color.Gainsboro;
            this.CadCarro.Image = ((System.Drawing.Image)(resources.GetObject("CadCarro.Image")));
            this.CadCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadCarro.Location = new System.Drawing.Point(0, 200);
            this.CadCarro.Name = "CadCarro";
            this.CadCarro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.CadCarro.Size = new System.Drawing.Size(220, 60);
            this.CadCarro.TabIndex = 3;
            this.CadCarro.Text = "  Cadastrar Carro";
            this.CadCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CadCarro.UseVisualStyleBackColor = true;
            this.CadCarro.Click += new System.EventHandler(this.CadCarro_Click);
            // 
            // ConCliente
            // 
            this.ConCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConCliente.FlatAppearance.BorderSize = 0;
            this.ConCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConCliente.Image = ((System.Drawing.Image)(resources.GetObject("ConCliente.Image")));
            this.ConCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConCliente.Location = new System.Drawing.Point(0, 140);
            this.ConCliente.Name = "ConCliente";
            this.ConCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ConCliente.Size = new System.Drawing.Size(220, 60);
            this.ConCliente.TabIndex = 2;
            this.ConCliente.Text = "  Consultar Cliente";
            this.ConCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConCliente.UseVisualStyleBackColor = true;
            this.ConCliente.Click += new System.EventHandler(this.ConCliente_Click);
            // 
            // CadCliente
            // 
            this.CadCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.CadCliente.FlatAppearance.BorderSize = 0;
            this.CadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.CadCliente.Image = ((System.Drawing.Image)(resources.GetObject("CadCliente.Image")));
            this.CadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadCliente.Location = new System.Drawing.Point(0, 80);
            this.CadCliente.Name = "CadCliente";
            this.CadCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.CadCliente.Size = new System.Drawing.Size(220, 60);
            this.CadCliente.TabIndex = 1;
            this.CadCliente.Text = "  Cadastrar Cliente";
            this.CadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CadCliente.UseVisualStyleBackColor = true;
            this.CadCliente.Click += new System.EventHandler(this.CadCliente_Cclick);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Serviços Brasil";
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(136)))));
            this.PanelTitleBar.Controls.Add(this.BtnMinimized);
            this.PanelTitleBar.Controls.Add(this.BtnMaximize);
            this.PanelTitleBar.Controls.Add(this.BtnClose);
            this.PanelTitleBar.Controls.Add(this.BtnCloseChildForm);
            this.PanelTitleBar.Controls.Add(this.lblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(628, 80);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimized.FlatAppearance.BorderSize = 0;
            this.BtnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimized.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimized.ForeColor = System.Drawing.Color.White;
            this.BtnMinimized.Location = new System.Drawing.Point(546, 0);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.Size = new System.Drawing.Size(30, 40);
            this.BtnMinimized.TabIndex = 4;
            this.BtnMinimized.Text = "-";
            this.BtnMinimized.UseVisualStyleBackColor = true;
            this.BtnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMaximize.ForeColor = System.Drawing.Color.White;
            this.BtnMaximize.Location = new System.Drawing.Point(573, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(30, 40);
            this.BtnMaximize.TabIndex = 3;
            this.BtnMaximize.Text = "º";
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(600, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 40);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCloseChildForm
            // 
            this.BtnCloseChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(136)))));
            this.BtnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseChildForm.Image = global::Projeto_Seguros.Properties.Resources.botao_de_retorno;
            this.BtnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.BtnCloseChildForm.Name = "BtnCloseChildForm";
            this.BtnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.BtnCloseChildForm.TabIndex = 1;
            this.BtnCloseChildForm.Text = "Retornar";
            this.BtnCloseChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCloseChildForm.UseVisualStyleBackColor = false;
            this.BtnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(260, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu Principal";
            // 
            // PanelDesktopPane
            // 
            this.PanelDesktopPane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelDesktopPane.Controls.Add(this.BtnOut);
            this.PanelDesktopPane.Controls.Add(this.BtnLight);
            this.PanelDesktopPane.Controls.Add(this.BtnDark);
            this.PanelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.PanelDesktopPane.Name = "PanelDesktopPane";
            this.PanelDesktopPane.Size = new System.Drawing.Size(628, 422);
            this.PanelDesktopPane.TabIndex = 2;
            // 
            // BtnOut
            // 
            this.BtnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOut.FlatAppearance.BorderSize = 0;
            this.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOut.Location = new System.Drawing.Point(530, 55);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(90, 23);
            this.BtnOut.TabIndex = 2;
            this.BtnOut.Text = "Logout";
            this.BtnOut.UseVisualStyleBackColor = true;
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // BtnLight
            // 
            this.BtnLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLight.FlatAppearance.BorderSize = 0;
            this.BtnLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLight.Location = new System.Drawing.Point(530, 30);
            this.BtnLight.Name = "BtnLight";
            this.BtnLight.Size = new System.Drawing.Size(90, 23);
            this.BtnLight.TabIndex = 1;
            this.BtnLight.Text = "Light Mode";
            this.BtnLight.UseVisualStyleBackColor = true;
            this.BtnLight.Click += new System.EventHandler(this.BtnLight_Click);
            // 
            // BtnDark
            // 
            this.BtnDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDark.FlatAppearance.BorderSize = 0;
            this.BtnDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDark.Location = new System.Drawing.Point(530, 5);
            this.BtnDark.Name = "BtnDark";
            this.BtnDark.Size = new System.Drawing.Size(90, 23);
            this.BtnDark.TabIndex = 0;
            this.BtnDark.Text = "Dark Mode";
            this.BtnDark.UseVisualStyleBackColor = true;
            this.BtnDark.Click += new System.EventHandler(this.BtnDark_Click);
            // 
            // PlataformaSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Controls.Add(this.PanelDesktopPane);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlataformaSeguros";
            this.Text = "PlataformaSeguros";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.PanelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button AciSeguro;
        private System.Windows.Forms.Button ConCarro;
        private System.Windows.Forms.Button CadCarro;
        private System.Windows.Forms.Button ConCliente;
        private System.Windows.Forms.Button CadCliente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelDesktopPane;
        private System.Windows.Forms.Button BtnCloseChildForm;
        private System.Windows.Forms.Button BtnMinimized;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnLight;
        private System.Windows.Forms.Button BtnDark;
        private System.Windows.Forms.Button BtnOut;
    }
}

