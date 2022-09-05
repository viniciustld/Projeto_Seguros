
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
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
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
            // botao1
            // 
            this.botao1.FlatAppearance.BorderSize = 0;
            this.botao1.Location = new System.Drawing.Point(150, 50);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(100, 23);
            this.botao1.TabIndex = 23;
            this.botao1.Text = "Ligar/Desligar";
            this.botao1.UseVisualStyleBackColor = true;
            // 
            // botao2
            // 
            this.botao2.FlatAppearance.BorderSize = 0;
            this.botao2.Location = new System.Drawing.Point(150, 80);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(100, 23);
            this.botao2.TabIndex = 24;
            this.botao2.Text = "Limpar";
            this.botao2.UseVisualStyleBackColor = true;
            // 
            // botao3
            // 
            this.botao3.FlatAppearance.BorderSize = 0;
            this.botao3.Location = new System.Drawing.Point(150, 110);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(100, 23);
            this.botao3.TabIndex = 25;
            this.botao3.Text = "Sair";
            this.botao3.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
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
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
    }
}