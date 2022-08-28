
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
            this.btnSetting = new System.Windows.Forms.Button();
            this.aciSeguro = new System.Windows.Forms.Button();
            this.conCarro = new System.Windows.Forms.Button();
            this.cadCarro = new System.Windows.Forms.Button();
            this.conCliente = new System.Windows.Forms.Button();
            this.cadCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.aciSeguro);
            this.panelMenu.Controls.Add(this.conCarro);
            this.panelMenu.Controls.Add(this.cadCarro);
            this.panelMenu.Controls.Add(this.conCliente);
            this.panelMenu.Controls.Add(this.cadCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 502);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Image = global::MultiColoredModernUI.Properties.Resources.settings;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 380);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(220, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "  Configurações";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // aciSeguro
            // 
            this.aciSeguro.Dock = System.Windows.Forms.DockStyle.Top;
            this.aciSeguro.FlatAppearance.BorderSize = 0;
            this.aciSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aciSeguro.ForeColor = System.Drawing.Color.Gainsboro;
            this.aciSeguro.Image = ((System.Drawing.Image)(resources.GetObject("aciSeguro.Image")));
            this.aciSeguro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aciSeguro.Location = new System.Drawing.Point(0, 320);
            this.aciSeguro.Name = "aciSeguro";
            this.aciSeguro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.aciSeguro.Size = new System.Drawing.Size(220, 60);
            this.aciSeguro.TabIndex = 5;
            this.aciSeguro.Text = "  Acionar Seguro";
            this.aciSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aciSeguro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aciSeguro.UseVisualStyleBackColor = true;
            this.aciSeguro.Click += new System.EventHandler(this.aciSeguro_Click);
            // 
            // conCarro
            // 
            this.conCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.conCarro.FlatAppearance.BorderSize = 0;
            this.conCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conCarro.ForeColor = System.Drawing.Color.Gainsboro;
            this.conCarro.Image = ((System.Drawing.Image)(resources.GetObject("conCarro.Image")));
            this.conCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conCarro.Location = new System.Drawing.Point(0, 260);
            this.conCarro.Name = "conCarro";
            this.conCarro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.conCarro.Size = new System.Drawing.Size(220, 60);
            this.conCarro.TabIndex = 4;
            this.conCarro.Text = "  Consultar Carro";
            this.conCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.conCarro.UseVisualStyleBackColor = true;
            this.conCarro.Click += new System.EventHandler(this.conCarro_Click);
            // 
            // cadCarro
            // 
            this.cadCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadCarro.FlatAppearance.BorderSize = 0;
            this.cadCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadCarro.ForeColor = System.Drawing.Color.Gainsboro;
            this.cadCarro.Image = ((System.Drawing.Image)(resources.GetObject("cadCarro.Image")));
            this.cadCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadCarro.Location = new System.Drawing.Point(0, 200);
            this.cadCarro.Name = "cadCarro";
            this.cadCarro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cadCarro.Size = new System.Drawing.Size(220, 60);
            this.cadCarro.TabIndex = 3;
            this.cadCarro.Text = "  Cadastrar Carro";
            this.cadCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadCarro.UseVisualStyleBackColor = true;
            this.cadCarro.Click += new System.EventHandler(this.cadCarro_Click);
            // 
            // conCliente
            // 
            this.conCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.conCliente.FlatAppearance.BorderSize = 0;
            this.conCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.conCliente.Image = ((System.Drawing.Image)(resources.GetObject("conCliente.Image")));
            this.conCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conCliente.Location = new System.Drawing.Point(0, 140);
            this.conCliente.Name = "conCliente";
            this.conCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.conCliente.Size = new System.Drawing.Size(220, 60);
            this.conCliente.TabIndex = 2;
            this.conCliente.Text = "  Consultar Cliente";
            this.conCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.conCliente.UseVisualStyleBackColor = true;
            this.conCliente.Click += new System.EventHandler(this.conCliente_Click);
            // 
            // cadCliente
            // 
            this.cadCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadCliente.FlatAppearance.BorderSize = 0;
            this.cadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.cadCliente.Image = ((System.Drawing.Image)(resources.GetObject("cadCliente.Image")));
            this.cadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadCliente.Location = new System.Drawing.Point(0, 80);
            this.cadCliente.Name = "cadCliente";
            this.cadCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cadCliente.Size = new System.Drawing.Size(220, 60);
            this.cadCliente.TabIndex = 1;
            this.cadCliente.Text = "  Cadastrar Cliente";
            this.cadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadCliente.UseVisualStyleBackColor = true;
            this.cadCliente.Click += new System.EventHandler(this.cadCliente_Cclick);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimized);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(628, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.Location = new System.Drawing.Point(546, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 40);
            this.btnMinimized.TabIndex = 4;
            this.btnMinimized.Text = "-";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(573, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 40);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "º";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(600, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::MultiColoredModernUI.Properties.Resources.cross_out__2_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
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
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(628, 422);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MultiColoredModernUI.Properties.Resources.UINP;
            this.pictureBox1.Location = new System.Drawing.Point(180, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlataformaSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "PlataformaSeguros";
            this.Text = "PlataformaSeguros";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button aciSeguro;
        private System.Windows.Forms.Button conCarro;
        private System.Windows.Forms.Button cadCarro;
        private System.Windows.Forms.Button conCliente;
        private System.Windows.Forms.Button cadCliente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}

