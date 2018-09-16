namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeCompra
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
            this.txtssenhausu = new System.Windows.Forms.TextBox();
            this.txtnmusu = new System.Windows.Forms.TextBox();
            this.dtppedido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(512, 273);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 10;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // txtssenhausu
            // 
            this.txtssenhausu.Location = new System.Drawing.Point(370, 249);
            this.txtssenhausu.Name = "txtssenhausu";
            this.txtssenhausu.Size = new System.Drawing.Size(100, 20);
            this.txtssenhausu.TabIndex = 8;
            // 
            // txtnmusu
            // 
            this.txtnmusu.Location = new System.Drawing.Point(370, 196);
            this.txtnmusu.Name = "txtnmusu";
            this.txtnmusu.Size = new System.Drawing.Size(100, 20);
            this.txtnmusu.TabIndex = 9;
            // 
            // dtppedido
            // 
            this.dtppedido.Location = new System.Drawing.Point(370, 154);
            this.dtppedido.Name = "dtppedido";
            this.dtppedido.Size = new System.Drawing.Size(200, 20);
            this.dtppedido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "senha do usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nome do usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "data do pedido de compra";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtssenhausu);
            this.Controls.Add(this.txtnmusu);
            this.Controls.Add(this.dtppedido);
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
        private System.Windows.Forms.TextBox txtssenhausu;
        private System.Windows.Forms.TextBox txtnmusu;
        private System.Windows.Forms.DateTimePicker dtppedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}