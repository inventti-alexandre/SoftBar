namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.FolhaDePagamento
{
    partial class frmNovo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btncadastar = new System.Windows.Forms.Button();
            this.dtpdatadepag = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "data de pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "valor de pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "observações;";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(210, 92);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(553, 51);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 1;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(210, 192);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(278, 83);
            this.txtobs.TabIndex = 1;
            // 
            // btncadastar
            // 
            this.btncadastar.Location = new System.Drawing.Point(553, 130);
            this.btncadastar.Name = "btncadastar";
            this.btncadastar.Size = new System.Drawing.Size(75, 23);
            this.btncadastar.TabIndex = 2;
            this.btncadastar.Text = "cadastrar";
            this.btncadastar.UseVisualStyleBackColor = true;
            // 
            // dtpdatadepag
            // 
            this.dtpdatadepag.Location = new System.Drawing.Point(210, 51);
            this.dtpdatadepag.Name = "dtpdatadepag";
            this.dtpdatadepag.Size = new System.Drawing.Size(200, 20);
            this.dtpdatadepag.TabIndex = 3;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpdatadepag);
            this.Controls.Add(this.btncadastar);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Button btncadastar;
        private System.Windows.Forms.DateTimePicker dtpdatadepag;
    }
}