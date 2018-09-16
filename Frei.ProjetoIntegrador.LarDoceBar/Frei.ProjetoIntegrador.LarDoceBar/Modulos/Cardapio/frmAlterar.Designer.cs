namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.Cardapio
{
    partial class frmAlterar
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtvalorpord = new System.Windows.Forms.TextBox();
            this.txttema = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(533, 283);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // txtvalorpord
            // 
            this.txtvalorpord.Location = new System.Drawing.Point(351, 233);
            this.txtvalorpord.Name = "txtvalorpord";
            this.txtvalorpord.Size = new System.Drawing.Size(100, 20);
            this.txtvalorpord.TabIndex = 6;
            // 
            // txttema
            // 
            this.txttema.Location = new System.Drawing.Point(351, 192);
            this.txttema.Name = "txttema";
            this.txttema.Size = new System.Drawing.Size(100, 20);
            this.txttema.TabIndex = 7;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(351, 145);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "valor do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "tema:";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtvalorpord);
            this.Controls.Add(this.txttema);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "frmAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtvalorpord;
        private System.Windows.Forms.TextBox txttema;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}