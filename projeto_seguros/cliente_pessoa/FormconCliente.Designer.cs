
namespace MultiColoredModernUI.Forms
{
    partial class FormconCliente
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
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.data003.TabIndex = 27;
            this.data003.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data003_CellContentDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Nome do Cliente";
            this.txtBuscar.Size = new System.Drawing.Size(245, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selecione o Cliente";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(10, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 25);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Editar Cadastro ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormconCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.data003);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormconCliente";
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.data003)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data003;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
    }
}