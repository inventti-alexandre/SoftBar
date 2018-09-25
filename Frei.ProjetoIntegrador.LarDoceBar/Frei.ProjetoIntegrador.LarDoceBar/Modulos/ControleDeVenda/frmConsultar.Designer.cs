namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeVenda
{
    partial class frmConsultar
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
            this.dgvViagem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViagem)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViagem
            // 
            this.dgvViagem.AllowUserToAddRows = false;
            this.dgvViagem.AllowUserToDeleteRows = false;
            this.dgvViagem.BackgroundColor = System.Drawing.Color.White;
            this.dgvViagem.ColumnHeadersHeight = 40;
            this.dgvViagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvViagem.Location = new System.Drawing.Point(128, 167);
            this.dgvViagem.Name = "dgvViagem";
            this.dgvViagem.ReadOnly = true;
            this.dgvViagem.RowHeadersVisible = false;
            this.dgvViagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvViagem.RowTemplate.Height = 30;
            this.dgvViagem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViagem.Size = new System.Drawing.Size(505, 220);
            this.dgvViagem.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "data";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nome usuário";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "nome cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "email cliente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "telefone cliente";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(266, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 34);
            this.label7.TabIndex = 64;
            this.label7.Text = "Consultar venda";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.Red;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(605, 397);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 36);
            this.btnremover.TabIndex = 62;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Red;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(713, 397);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 36);
            this.btnnovo.TabIndex = 63;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.Red;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnalterar.ForeColor = System.Drawing.Color.White;
            this.btnalterar.Location = new System.Drawing.Point(508, 396);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 37);
            this.btnalterar.TabIndex = 65;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Italic);
            this.txtNome.Location = new System.Drawing.Point(179, 132);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(445, 21);
            this.txtNome.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources._3b407e0fa32ec004492aec8bbd0e29c3;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(289, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 70);
            this.panel3.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 34);
            this.label10.TabIndex = 61;
            this.label10.Text = "Alterar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(649, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 39);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.juniper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dgvViagem);
            this.Name = "frmConsultar";
            this.Text = "frmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViagem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
    }
}