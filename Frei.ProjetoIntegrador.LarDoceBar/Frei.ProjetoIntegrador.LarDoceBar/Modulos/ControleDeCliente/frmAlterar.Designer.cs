namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeCliente
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
            this.pnDadosPessoais = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnEndereco = new System.Windows.Forms.Panel();
            this.btnSearchCEP = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnContato = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnDadosPessoais.SuspendLayout();
            this.pnEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDadosPessoais
            // 
            this.pnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.pnDadosPessoais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosPessoais.Controls.Add(this.txtNome);
            this.pnDadosPessoais.Controls.Add(this.label1);
            this.pnDadosPessoais.Controls.Add(this.label2);
            this.pnDadosPessoais.Controls.Add(this.txtCPF);
            this.pnDadosPessoais.Location = new System.Drawing.Point(169, 218);
            this.pnDadosPessoais.Name = "pnDadosPessoais";
            this.pnDadosPessoais.Size = new System.Drawing.Size(479, 78);
            this.pnDadosPessoais.TabIndex = 67;
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
            this.label1.Font = new System.Drawing.Font("Stencil", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(152, 48);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNTelefone
            // 
            this.txtNTelefone.Location = new System.Drawing.Point(350, 44);
            this.txtNTelefone.Mask = "(99) 9999-9999";
            this.txtNTelefone.Name = "txtNTelefone";
            this.txtNTelefone.Size = new System.Drawing.Size(109, 20);
            this.txtNTelefone.TabIndex = 14;
            this.txtNTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Red;
            this.label21.Font = new System.Drawing.Font("Stencil", 12F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(260, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Nº Telefone:";
            // 
            // txtNCelular
            // 
            this.txtNCelular.Location = new System.Drawing.Point(152, 44);
            this.txtNCelular.Mask = "(99) 99999-9999";
            this.txtNCelular.Name = "txtNCelular";
            this.txtNCelular.Size = new System.Drawing.Size(102, 20);
            this.txtNCelular.TabIndex = 13;
            this.txtNCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(370, 74);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(89, 20);
            this.txtUF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(204, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Dados Pessoais";
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
            this.pnEndereco.Location = new System.Drawing.Point(169, 325);
            this.pnEndereco.Name = "pnEndereco";
            this.pnEndereco.Size = new System.Drawing.Size(479, 143);
            this.pnEndereco.TabIndex = 68;
            // 
            // btnSearchCEP
            // 
            this.btnSearchCEP.BackColor = System.Drawing.Color.Red;
            this.btnSearchCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCEP.FlatAppearance.BorderSize = 0;
            this.btnSearchCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCEP.Font = new System.Drawing.Font("Stencil", 12F);
            this.btnSearchCEP.ForeColor = System.Drawing.Color.White;
            this.btnSearchCEP.Location = new System.Drawing.Point(258, 17);
            this.btnSearchCEP.Name = "btnSearchCEP";
            this.btnSearchCEP.Size = new System.Drawing.Size(73, 24);
            this.btnSearchCEP.TabIndex = 6;
            this.btnSearchCEP.Text = "Buscar";
            this.btnSearchCEP.UseVisualStyleBackColor = false;
            this.btnSearchCEP.Click += new System.EventHandler(this.btnSearchCEP_Click);
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
            this.label13.Font = new System.Drawing.Font("Stencil", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(337, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "UF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Stencil", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(94, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Stencil", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(45, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 19);
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
            this.label6.Font = new System.Drawing.Font("Stencil", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Logradouro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(111, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "CEP:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Red;
            this.lblId.Font = new System.Drawing.Font("Stencil", 12F);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(459, 195);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 19);
            this.lblId.TabIndex = 62;
            this.lblId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.lar_doce_bar3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(348, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Stencil", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(353, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "Cadastrar  Novo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Red;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Stencil", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(511, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 31);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 330);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 208);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Red;
            this.label19.Font = new System.Drawing.Font("Stencil", 12F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(69, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nº Celular:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(672, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 208);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pnContato
            // 
            this.pnContato.BackColor = System.Drawing.Color.Transparent;
            this.pnContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContato.Controls.Add(this.txtNTelefone);
            this.pnContato.Controls.Add(this.label21);
            this.pnContato.Controls.Add(this.txtNCelular);
            this.pnContato.Controls.Add(this.label19);
            this.pnContato.Controls.Add(this.txtEmail);
            this.pnContato.Controls.Add(this.label18);
            this.pnContato.Location = new System.Drawing.Point(169, 499);
            this.pnContato.Name = "pnContato";
            this.pnContato.Size = new System.Drawing.Size(479, 82);
            this.pnContato.TabIndex = 69;
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
            this.label18.Font = new System.Drawing.Font("Stencil", 12F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(95, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "E-mail:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Red;
            this.label20.Font = new System.Drawing.Font("Stencil", 12F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(204, 480);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 19);
            this.label20.TabIndex = 65;
            this.label20.Text = "Contato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(204, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "Endereço";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.swsb_character_fact_duffman_550x960;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(654, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 370);
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.swsb_character_fact_doris_550x9601;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(-11, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(174, 367);
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.voltar;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(3, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(127, 35);
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.LarDoceBar.Properties.Resources.juniper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 532);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnDadosPessoais);
            this.Controls.Add(this.pnEndereco);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnContato);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lar Doce Bar LTDA";
            this.pnDadosPessoais.ResumeLayout(false);
            this.pnDadosPessoais.PerformLayout();
            this.pnEndereco.ResumeLayout(false);
            this.pnEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnContato.ResumeLayout(false);
            this.pnContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtNTelefone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox txtNCelular;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnEndereco;
        private System.Windows.Forms.Button btnSearchCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}