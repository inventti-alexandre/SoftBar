namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeCompra
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
            this.dtppedido = new System.Windows.Forms.DateTimePicker();
            this.txtnmusu = new System.Windows.Forms.TextBox();
            this.txtssenhausu = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "data do pedido de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "senha do usuário:";
            // 
            // dtppedido
            // 
            this.dtppedido.Location = new System.Drawing.Point(210, 48);
            this.dtppedido.Name = "dtppedido";
            this.dtppedido.Size = new System.Drawing.Size(200, 20);
            this.dtppedido.TabIndex = 1;
            // 
            // txtnmusu
            // 
            this.txtnmusu.Location = new System.Drawing.Point(210, 90);
            this.txtnmusu.Name = "txtnmusu";
            this.txtnmusu.Size = new System.Drawing.Size(100, 20);
            this.txtnmusu.TabIndex = 2;
            // 
            // txtssenhausu
            // 
            this.txtssenhausu.Location = new System.Drawing.Point(210, 143);
            this.txtssenhausu.Name = "txtssenhausu";
            this.txtssenhausu.Size = new System.Drawing.Size(100, 20);
            this.txtssenhausu.TabIndex = 2;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(352, 167);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 3;
            this.btncad.Text = "cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtssenhausu);
            this.Controls.Add(this.txtnmusu);
            this.Controls.Add(this.dtppedido);
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
        private System.Windows.Forms.DateTimePicker dtppedido;
        private System.Windows.Forms.TextBox txtnmusu;
        private System.Windows.Forms.TextBox txtssenhausu;
        private System.Windows.Forms.Button btncad;
    }
}