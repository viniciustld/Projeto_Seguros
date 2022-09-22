
namespace MultiColoredModernUI.Forms
{
    partial class FormaciSeguro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data003 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data003)).BeginInit();
            this.SuspendLayout();
            // 
            // data003
            // 
            this.data003.AllowUserToAddRows = false;
            this.data003.AllowUserToDeleteRows = false;
            this.data003.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data003.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data003.Location = new System.Drawing.Point(12, 40);
            this.data003.Name = "data003";
            this.data003.ReadOnly = true;
            this.data003.RowTemplate.Height = 25;
            this.data003.Size = new System.Drawing.Size(600, 200);
            this.data003.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Código da Ocorrência";
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquise a Ocorrência";
            // 
            // btnAcionar
            // 
            this.btnAcionar.Location = new System.Drawing.Point(12, 250);
            this.btnAcionar.Name = "btnAcionar";
            this.btnAcionar.Size = new System.Drawing.Size(75, 23);
            this.btnAcionar.TabIndex = 5;
            this.btnAcionar.Text = "Acionar";
            this.btnAcionar.UseVisualStyleBackColor = true;
            this.btnAcionar.Click += new System.EventHandler(this.btnAcionar_Click);
            // 
            // FormaciSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.btnAcionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.data003);
            this.Name = "FormaciSeguro";
            this.Text = "Acionar Seguro";
            ((System.ComponentModel.ISupportInitialize)(this.data003)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data003;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcionar;
    }
}