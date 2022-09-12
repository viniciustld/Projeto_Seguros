
namespace MultiColoredModernUI.Forms
{
    partial class FormcadCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtfkcarro = new System.Windows.Forms.TextBox();
            this.data001 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data001)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(200, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Nome do Cliente";
            this.txtBuscar.Size = new System.Drawing.Size(245, 23);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(200, 251);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(245, 23);
            this.txtPlaca.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(200, 281);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(245, 23);
            this.txtMarca.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(200, 221);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(245, 23);
            this.txtCor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cor";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(200, 311);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(245, 23);
            this.txtModelo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(200, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 27);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtfkcarro
            // 
            this.txtfkcarro.Location = new System.Drawing.Point(200, 341);
            this.txtfkcarro.Name = "txtfkcarro";
            this.txtfkcarro.ReadOnly = true;
            this.txtfkcarro.Size = new System.Drawing.Size(245, 23);
            this.txtfkcarro.TabIndex = 19;
            // 
            // data001
            // 
            this.data001.AllowUserToAddRows = false;
            this.data001.AllowUserToDeleteRows = false;
            this.data001.AllowUserToOrderColumns = true;
            this.data001.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data001.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.data001.Location = new System.Drawing.Point(200, 41);
            this.data001.Name = "data001";
            this.data001.ReadOnly = true;
            this.data001.RowTemplate.Height = 25;
            this.data001.Size = new System.Drawing.Size(245, 170);
            this.data001.TabIndex = 20;
            this.data001.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data001_CellContentDoubleClick);
            // 
            // FormcadCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.data001);
            this.Controls.Add(this.txtfkcarro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormcadCarro";
            this.Text = "Cadastrar Carro";
            ((System.ComponentModel.ISupportInitialize)(this.data001)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtfkcarro;
        private System.Windows.Forms.DataGridView data001;
    }
}