namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.Cardapio
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
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.txttema = new System.Windows.Forms.TextBox();
            this.txtvalorpord = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tema:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nome do produto:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "valor do produto:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(221, 50);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprod.TabIndex = 1;
            // 
            // txttema
            // 
            this.txttema.Location = new System.Drawing.Point(221, 97);
            this.txttema.Name = "txttema";
            this.txttema.Size = new System.Drawing.Size(100, 20);
            this.txttema.TabIndex = 1;
            // 
            // txtvalorpord
            // 
            this.txtvalorpord.Location = new System.Drawing.Point(221, 138);
            this.txtvalorpord.Name = "txtvalorpord";
            this.txtvalorpord.Size = new System.Drawing.Size(100, 20);
            this.txtvalorpord.TabIndex = 1;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(403, 188);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 2;
            this.btncad.Text = "cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtvalorpord);
            this.Controls.Add(this.txttema);
            this.Controls.Add(this.txtnomeprod);
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
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.TextBox txttema;
        private System.Windows.Forms.TextBox txtvalorpord;
        private System.Windows.Forms.Button btncad;
    }
}