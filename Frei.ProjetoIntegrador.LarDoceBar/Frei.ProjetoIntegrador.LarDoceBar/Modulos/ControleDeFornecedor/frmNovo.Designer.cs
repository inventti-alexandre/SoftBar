namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFornecedor
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
            this.pnEndereco = new System.Windows.Forms.Panel();
            this.btnSearchCEP = new System.Windows.Forms.Button();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnDadosPessoais = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.pnContato = new System.Windows.Forms.Panel();
            this.txtNTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnEndereco.SuspendLayout();
            this.pnDadosPessoais.SuspendLayout();
            this.pnContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEndereco
            // 
            this.pnEndereco.BackColor = System.Drawing.Color.Transparent;
            this.pnEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEndereco.Controls.Add(this.btnSearchCEP);
            this.pnEndereco.Controls.Add(this.txtUF);
            this.pnEndereco.Controls.Add(this.txtBairro);
            this.pnEndereco.Controls.Add(this.txtComplemento);
            this.pnEndereco.Controls.Add(this.txtLogradouro);
            this.pnEndereco.Controls.Add(this.label13);
            this.pnEndereco.Controls.Add(this.label12);
            this.pnEndereco.Controls.Add(this.label14);
            this.pnEndereco.Controls.Add(this.txtCEP);
            this.pnEndereco.Controls.Add(this.label6);
            this.pnEndereco.Controls.Add(this.label7);
            this.pnEndereco.Location = new System.Drawing.Point(130, 338);
            this.pnEndereco.Name = "pnEndereco";
            this.pnEndereco.Size = new System.Drawing.Size(479, 143);
            this.pnEndereco.TabIndex = 55;
            this.pnEndereco.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEndereco_Paint);
            // 
            // btnSearchCEP
            // 
            this.btnSearchCEP.BackColor = System.Drawing.Color.Red;
            this.btnSearchCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCEP.FlatAppearance.BorderSize = 0;
            this.btnSearchCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCEP.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnSearchCEP.ForeColor = System.Drawing.Color.White;
            this.btnSearchCEP.Location = new System.Drawing.Point(258, 17);
            this.btnSearchCEP.Name = "btnSearchCEP";
            this.btnSearchCEP.Size = new System.Drawing.Size(83, 24);
            this.btnSearchCEP.TabIndex = 6;
            this.btnSearchCEP.Text = "Buscar";
            this.btnSearchCEP.UseVisualStyleBackColor = false;
            this.btnSearchCEP.Click += new System.EventHandler(this.btnSearchCEP_Click);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(370, 74);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(89, 20);
            this.txtUF.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(152, 74);
            this.txtBairro.MaxLength = 150;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(179, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(152, 100);
            this.txtComplemento.MaxLength = 150;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(307, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(152, 48);
            this.txtLogradouro.MaxLength = 200;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(307, 20);
            this.txtLogradouro.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(337, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "UF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(94, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(45, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Complemento:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(152, 22);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 5;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Logradouro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(111, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "CEP:";
            // 
            // pnDadosPessoais
            // 
            this.pnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.pnDadosPessoais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosPessoais.Controls.Add(this.txtNome);
            this.pnDadosPessoais.Controls.Add(this.label1);
            this.pnDadosPessoais.Controls.Add(this.label2);
            this.pnDadosPessoais.Controls.Add(this.txtCNPJ);
            this.pnDadosPessoais.Location = new System.Drawing.Point(130, 209);
            this.pnDadosPessoais.Name = "pnDadosPessoais";
            this.pnDadosPessoais.Size = new System.Drawing.Size(479, 92);
            this.pnDadosPessoais.TabIndex = 54;
            this.pnDadosPessoais.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDadosPessoais_Paint);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 22);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(152, 48);
            this.txtCNPJ.Mask = "99,999,999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(307, 20);
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dados Pessoais";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(279, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 34);
            this.label11.TabIndex = 58;
            this.label11.Text = "Cadastrar  Novo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(326, 616);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 28);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Red;
            this.label20.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(165, 497);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 29);
            this.label20.TabIndex = 52;
            this.label20.Text = "Contato";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // pnContato
            // 
            this.pnContato.BackColor = System.Drawing.Color.Transparent;
            this.pnContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContato.Controls.Add(this.txtNTelefone);
            this.pnContato.Controls.Add(this.label21);
            this.pnContato.Controls.Add(this.txtEmail);
            this.pnContato.Controls.Add(this.label18);
            this.pnContato.Location = new System.Drawing.Point(130, 516);
            this.pnContato.Name = "pnContato";
            this.pnContato.Size = new System.Drawing.Size(479, 82);
            this.pnContato.TabIndex = 56;
            this.pnContato.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContato_Paint);
            // 
            // txtNTelefone
            // 
            this.txtNTelefone.Location = new System.Drawing.Point(152, 44);
            this.txtNTelefone.Mask = "(99) 9999-9999";
            this.txtNTelefone.Name = "txtNTelefone";
            this.txtNTelefone.Size = new System.Drawing.Size(307, 20);
            this.txtNTelefone.TabIndex = 14;
            this.txtNTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Red;
            this.label21.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(62, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Nº Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Red;
            this.label18.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(95, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(165, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 29);
            this.label10.TabIndex = 51;
            this.label10.Text = "Endereço";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.lar_doce_bar10;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.panel3.Location = new System.Drawing.Point(260, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 113);
            this.panel3.TabIndex = 70;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.juniper_1;
            this.ClientSize = new System.Drawing.Size(831, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnEndereco);
            this.Controls.Add(this.pnDadosPessoais);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pnContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lar Doce Bar LTDA";
            this.pnEndereco.ResumeLayout(false);
            this.pnEndereco.PerformLayout();
            this.pnDadosPessoais.ResumeLayout(false);
            this.pnDadosPessoais.PerformLayout();
            this.pnContato.ResumeLayout(false);
            this.pnContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnEndereco;
        private System.Windows.Forms.Button btnSearchCEP;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnContato;
        private System.Windows.Forms.MaskedTextBox txtNTelefone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}