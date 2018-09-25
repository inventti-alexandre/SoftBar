namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttelfor = new System.Windows.Forms.TextBox();
            this.txtvlprod = new System.Windows.Forms.TextBox();
            this.txtcnpjfor = new System.Windows.Forms.TextBox();
            this.txtnomefor = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txttelfor);
            this.panel1.Controls.Add(this.txtvlprod);
            this.panel1.Controls.Add(this.txtcnpjfor);
            this.panel1.Controls.Add(this.txtnomefor);
            this.panel1.Controls.Add(this.txtnomeprod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 209);
            this.panel1.TabIndex = 50;
            // 
            // txttelfor
            // 
            this.txttelfor.Location = new System.Drawing.Point(514, 84);
            this.txttelfor.Name = "txttelfor";
            this.txttelfor.Size = new System.Drawing.Size(153, 20);
            this.txttelfor.TabIndex = 18;
            // 
            // txtvlprod
            // 
            this.txtvlprod.Location = new System.Drawing.Point(514, 32);
            this.txtvlprod.Name = "txtvlprod";
            this.txtvlprod.Size = new System.Drawing.Size(153, 20);
            this.txtvlprod.TabIndex = 19;
            // 
            // txtcnpjfor
            // 
            this.txtcnpjfor.Location = new System.Drawing.Point(172, 151);
            this.txtcnpjfor.Name = "txtcnpjfor";
            this.txtcnpjfor.Size = new System.Drawing.Size(138, 20);
            this.txtcnpjfor.TabIndex = 20;
            // 
            // txtnomefor
            // 
            this.txtnomefor.Location = new System.Drawing.Point(172, 87);
            this.txtnomefor.Name = "txtnomefor";
            this.txtnomefor.Size = new System.Drawing.Size(138, 20);
            this.txtnomefor.TabIndex = 21;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(172, 35);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(138, 20);
            this.txtnomeprod.TabIndex = 22;
            this.txtnomeprod.TextChanged += new System.EventHandler(this.txtnomeprod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "CNPJ do Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone do Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome do Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(390, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome do Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(333, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 34);
            this.label8.TabIndex = 51;
            this.label8.Text = "Alterar Produtos";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(642, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 47);
            this.btnCadastrar.TabIndex = 65;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources._3b407e0fa32ec004492aec8bbd0e29c3;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(258, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 114);
            this.panel3.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 34);
            this.label7.TabIndex = 61;
            this.label7.Text = "Alterar";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.juniper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lar Doce Bar LTDA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttelfor;
        private System.Windows.Forms.TextBox txtvlprod;
        private System.Windows.Forms.TextBox txtcnpjfor;
        private System.Windows.Forms.TextBox txtnomefor;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}