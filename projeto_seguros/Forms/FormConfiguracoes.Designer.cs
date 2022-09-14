
namespace MultiColoredModernUI.Forms
{
    partial class FormConfiguracoes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Logout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Limpar Cache";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Modo Noturno";
            // 
            // btnColor
            // 
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.Location = new System.Drawing.Point(150, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 23);
            this.btnColor.TabIndex = 23;
            this.btnColor.Text = "Ligar/Desligar";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(150, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.Location = new System.Drawing.Point(150, 110);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 23);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracoes";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}