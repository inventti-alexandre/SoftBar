namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeProdutos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.txtnomefor = new System.Windows.Forms.TextBox();
            this.txtcnpjfor = new System.Windows.Forms.TextBox();
            this.txtvlprod = new System.Windows.Forms.TextBox();
            this.txttelfor = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nome do fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNPJ do fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "valor do produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "telefone do fornecedor:";
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(203, 22);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprod.TabIndex = 1;
            // 
            // txtnomefor
            // 
            this.txtnomefor.Location = new System.Drawing.Point(203, 56);
            this.txtnomefor.Name = "txtnomefor";
            this.txtnomefor.Size = new System.Drawing.Size(100, 20);
            this.txtnomefor.TabIndex = 1;
            // 
            // txtcnpjfor
            // 
            this.txtcnpjfor.Location = new System.Drawing.Point(203, 90);
            this.txtcnpjfor.Name = "txtcnpjfor";
            this.txtcnpjfor.Size = new System.Drawing.Size(100, 20);
            this.txtcnpjfor.TabIndex = 1;
            // 
            // txtvlprod
            // 
            this.txtvlprod.Location = new System.Drawing.Point(203, 133);
            this.txtvlprod.Name = "txtvlprod";
            this.txtvlprod.Size = new System.Drawing.Size(100, 20);
            this.txtvlprod.TabIndex = 1;
            // 
            // txttelfor
            // 
            this.txttelfor.Location = new System.Drawing.Point(203, 167);
            this.txttelfor.Name = "txttelfor";
            this.txttelfor.Size = new System.Drawing.Size(100, 20);
            this.txttelfor.TabIndex = 1;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(242, 240);
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
            this.Controls.Add(this.txttelfor);
            this.Controls.Add(this.txtvlprod);
            this.Controls.Add(this.txtcnpjfor);
            this.Controls.Add(this.txtnomefor);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.TextBox txtnomefor;
        private System.Windows.Forms.TextBox txtcnpjfor;
        private System.Windows.Forms.TextBox txtvlprod;
        private System.Windows.Forms.TextBox txttelfor;
        private System.Windows.Forms.Button btncad;
    }
}