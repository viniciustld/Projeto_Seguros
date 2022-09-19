
namespace MultiColoredModernUI.Forms
{
    partial class AcionarSeguro
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcdOcorrencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAcionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.data003 = new System.Windows.Forms.DataGridView();
            this.txtfk_carro_placa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data003)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(150, 240);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(150, 270);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(150, 330);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 23);
            this.txtRua.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rua";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(150, 300);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bairro";
            // 
            // txtcdOcorrencia
            // 
            this.txtcdOcorrencia.Location = new System.Drawing.Point(150, 210);
            this.txtcdOcorrencia.Name = "txtcdOcorrencia";
            this.txtcdOcorrencia.Size = new System.Drawing.Size(200, 23);
            this.txtcdOcorrencia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código da Ocorrência";
            // 
            // btnAcionar
            // 
            this.btnAcionar.Location = new System.Drawing.Point(152, 429);
            this.btnAcionar.Name = "btnAcionar";
            this.btnAcionar.Size = new System.Drawing.Size(80, 25);
            this.btnAcionar.TabIndex = 10;
            this.btnAcionar.Text = "Acionar";
            this.btnAcionar.UseVisualStyleBackColor = true;
            this.btnAcionar.Click += new System.EventHandler(this.btnAcionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione o Carro";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Cpf do Cliente";
            this.txtBuscar.Size = new System.Drawing.Size(144, 23);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // data003
            // 
            this.data003.AllowUserToAddRows = false;
            this.data003.AllowUserToDeleteRows = false;
            this.data003.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data003.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data003.Location = new System.Drawing.Point(50, 50);
            this.data003.Name = "data003";
            this.data003.ReadOnly = true;
            this.data003.RowTemplate.Height = 25;
            this.data003.Size = new System.Drawing.Size(420, 150);
            this.data003.TabIndex = 11;
            this.data003.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data003_CellContentDoubleClick);
            // 
            // txtfk_carro_placa
            // 
            this.txtfk_carro_placa.Location = new System.Drawing.Point(150, 360);
            this.txtfk_carro_placa.Name = "txtfk_carro_placa";
            this.txtfk_carro_placa.Size = new System.Drawing.Size(200, 23);
            this.txtfk_carro_placa.TabIndex = 14;
            this.txtfk_carro_placa.Visible = false;
            // 
            // AcionarSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtfk_carro_placa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.data003);
            this.Controls.Add(this.btnAcionar);
            this.Controls.Add(this.txtcdOcorrencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "AcionarSeguro";
            this.Text = "Acionamento do Seguro";
            ((System.ComponentModel.ISupportInitialize)(this.data003)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcdOcorrencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAcionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView data003;
        private System.Windows.Forms.TextBox txtfk_carro_placa;
    }
}