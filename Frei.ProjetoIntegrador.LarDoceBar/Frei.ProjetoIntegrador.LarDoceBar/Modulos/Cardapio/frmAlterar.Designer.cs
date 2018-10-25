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
            this.txtvalorpord = new System.Windows.Forms.TextBox();
            this.txttema = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalorpord
            // 
            this.txtvalorpord.Location = new System.Drawing.Point(207, 181);
            this.txtvalorpord.Name = "txtvalorpord";
            this.txtvalorpord.Size = new System.Drawing.Size(234, 20);
            this.txtvalorpord.TabIndex = 6;
            // 
            // txttema
            // 
            this.txttema.Location = new System.Drawing.Point(207, 140);
            this.txttema.Name = "txttema";
            this.txttema.Size = new System.Drawing.Size(234, 20);
            this.txttema.TabIndex = 7;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(207, 93);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(234, 20);
            this.txtnomeprod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tema:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtvalorpord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttema);
            this.panel1.Controls.Add(this.txtnomeprod);
            this.panel1.Location = new System.Drawing.Point(105, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 227);
            this.panel1.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(219, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 34);
            this.label11.TabIndex = 63;
            this.label11.Text = "Alterar Cardapio";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.lar_doce_bar2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(278, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 166);
            this.panel3.TabIndex = 53;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Red;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(666, 469);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(88, 39);
            this.btnsalvar.TabIndex = 62;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.juniper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 532);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lar Doce Bar LTDA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtvalorpord;
        private System.Windows.Forms.TextBox txttema;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label11;
    }
}