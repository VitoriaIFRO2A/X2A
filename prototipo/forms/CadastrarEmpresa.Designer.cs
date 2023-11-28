namespace prototipo
{
    partial class CadastrarEmpresa
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
            this.cb_situacaocadastral = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.tb_razaosocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_regime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.mb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_capitalsocial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nomefantasia = new System.Windows.Forms.TextBox();
            this.rb_matriz = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rb_filial = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rb_me = new System.Windows.Forms.RadioButton();
            this.rb_gra = new System.Windows.Forms.RadioButton();
            this.rb_pe = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_naturezajuridica = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_nomeproprietario = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razão Social:";
            // 
            // cb_situacaocadastral
            // 
            this.cb_situacaocadastral.FormattingEnabled = true;
            this.cb_situacaocadastral.Items.AddRange(new object[] {
            "Ativa ",
            "Nula",
            "Suspensa",
            "Inapta ",
            "Baixada"});
            this.cb_situacaocadastral.Location = new System.Drawing.Point(193, 148);
            this.cb_situacaocadastral.Name = "cb_situacaocadastral";
            this.cb_situacaocadastral.Size = new System.Drawing.Size(84, 21);
            this.cb_situacaocadastral.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Situação Cadastral :";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(76, 24);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(192, 20);
            this.tb_cnpj.TabIndex = 4;
            // 
            // tb_razaosocial
            // 
            this.tb_razaosocial.Location = new System.Drawing.Point(138, 71);
            this.tb_razaosocial.Name = "tb_razaosocial";
            this.tb_razaosocial.Size = new System.Drawing.Size(139, 20);
            this.tb_razaosocial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Regime Tributário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome Fantasia:";
            // 
            // cb_regime
            // 
            this.cb_regime.FormattingEnabled = true;
            this.cb_regime.Items.AddRange(new object[] {
            "Simples Nacional",
            "Lucro Presumido",
            "Real"});
            this.cb_regime.Location = new System.Drawing.Point(183, 192);
            this.cb_regime.Name = "cb_regime";
            this.cb_regime.Size = new System.Drawing.Size(85, 21);
            this.cb_regime.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de Início de Atividade:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone:";
            // 
            // mb_telefone
            // 
            this.mb_telefone.Location = new System.Drawing.Point(107, 295);
            this.mb_telefone.Mask = "(00) 00000-0000";
            this.mb_telefone.Name = "mb_telefone";
            this.mb_telefone.Size = new System.Drawing.Size(100, 20);
            this.mb_telefone.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Capital Social:";
            // 
            // tb_capitalsocial
            // 
            this.tb_capitalsocial.Location = new System.Drawing.Point(149, 345);
            this.tb_capitalsocial.Name = "tb_capitalsocial";
            this.tb_capitalsocial.Size = new System.Drawing.Size(119, 20);
            this.tb_capitalsocial.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço Completo:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(201, 384);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(116, 20);
            this.tb_endereco.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Acre (AC)",
            "",
            "Alagoas  (AL)",
            "",
            "Amapá (AP)",
            "",
            "Amazonas (AM)",
            "",
            "Bahia (BA)",
            "",
            "Ceará (CE)",
            "",
            "Espírito Santo (ES)",
            "",
            "Goiás (GO)",
            "",
            "Maranhão (MA)",
            "",
            "Mato Grosso (MT)",
            "",
            "Mato Grosso do Sul (MS)",
            "",
            "Minas Gerais (MG)",
            "",
            "Pará (PA)",
            "",
            "Paraíba (PB)",
            "",
            "Paraná (PR)",
            "",
            "Pernambuco (PE)",
            "",
            "Piauí (PI)",
            "",
            "Rio de Janeiro (RJ)",
            "",
            "Rio Grande do Norte (RN)",
            "",
            "Rio Grande do Sul (RS)",
            "",
            "Rondônia (RO)",
            "",
            "Roraima (RR)",
            "",
            "Santa Catarina (SC)",
            "",
            "São Paulo (SP)",
            "",
            "Sergipe (SE)",
            "",
            "Tocantins (TO)",
            "",
            "Distrito Federal (DF)"});
            this.comboBox3.Location = new System.Drawing.Point(91, 420);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado:";
            // 
            // tb_nomefantasia
            // 
            this.tb_nomefantasia.Location = new System.Drawing.Point(157, 112);
            this.tb_nomefantasia.Name = "tb_nomefantasia";
            this.tb_nomefantasia.Size = new System.Drawing.Size(118, 20);
            this.tb_nomefantasia.TabIndex = 19;
            // 
            // rb_matriz
            // 
            this.rb_matriz.AutoSize = true;
            this.rb_matriz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_matriz.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.rb_matriz.Location = new System.Drawing.Point(525, 105);
            this.rb_matriz.Name = "rb_matriz";
            this.rb_matriz.Size = new System.Drawing.Size(82, 27);
            this.rb_matriz.TabIndex = 20;
            this.rb_matriz.TabStop = true;
            this.rb_matriz.Text = "Matriz";
            this.rb_matriz.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label11.Location = new System.Drawing.Point(439, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tipo:";
            // 
            // rb_filial
            // 
            this.rb_filial.AutoSize = true;
            this.rb_filial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_filial.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.rb_filial.Location = new System.Drawing.Point(640, 105);
            this.rb_filial.Name = "rb_filial";
            this.rb_filial.Size = new System.Drawing.Size(67, 27);
            this.rb_filial.TabIndex = 22;
            this.rb_filial.TabStop = true;
            this.rb_filial.Text = "Filial";
            this.rb_filial.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label12.Location = new System.Drawing.Point(298, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Porte de Empresa:";
            // 
            // rb_me
            // 
            this.rb_me.AutoSize = true;
            this.rb_me.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_me.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.rb_me.Location = new System.Drawing.Point(584, 160);
            this.rb_me.Name = "rb_me";
            this.rb_me.Size = new System.Drawing.Size(82, 27);
            this.rb_me.TabIndex = 24;
            this.rb_me.TabStop = true;
            this.rb_me.Text = "Médio";
            this.rb_me.UseVisualStyleBackColor = false;
            // 
            // rb_gra
            // 
            this.rb_gra.AutoSize = true;
            this.rb_gra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_gra.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.rb_gra.Location = new System.Drawing.Point(672, 160);
            this.rb_gra.Name = "rb_gra";
            this.rb_gra.Size = new System.Drawing.Size(90, 27);
            this.rb_gra.TabIndex = 25;
            this.rb_gra.TabStop = true;
            this.rb_gra.Text = "Grande";
            this.rb_gra.UseVisualStyleBackColor = false;
            // 
            // rb_pe
            // 
            this.rb_pe.AutoSize = true;
            this.rb_pe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_pe.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.rb_pe.Location = new System.Drawing.Point(466, 160);
            this.rb_pe.Name = "rb_pe";
            this.rb_pe.Size = new System.Drawing.Size(103, 27);
            this.rb_pe.TabIndex = 26;
            this.rb_pe.TabStop = true;
            this.rb_pe.Text = "Pequeno";
            this.rb_pe.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label13.Location = new System.Drawing.Point(382, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Natureza Juridica:";
            // 
            // cb_naturezajuridica
            // 
            this.cb_naturezajuridica.FormattingEnabled = true;
            this.cb_naturezajuridica.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            " MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            " Sociedade Limitada Unipessoal"});
            this.cb_naturezajuridica.Location = new System.Drawing.Point(588, 212);
            this.cb_naturezajuridica.Name = "cb_naturezajuridica";
            this.cb_naturezajuridica.Size = new System.Drawing.Size(174, 21);
            this.cb_naturezajuridica.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label14.Location = new System.Drawing.Point(382, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Nome Proprietario:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label15.Location = new System.Drawing.Point(382, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "CPF Funcionario:";
            // 
            // tb_nomeproprietario
            // 
            this.tb_nomeproprietario.Location = new System.Drawing.Point(588, 270);
            this.tb_nomeproprietario.Name = "tb_nomeproprietario";
            this.tb_nomeproprietario.Size = new System.Drawing.Size(174, 20);
            this.tb_nomeproprietario.TabIndex = 32;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(662, 326);
            this.tb_cpf.Mask = "000,000,000,-00";
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(100, 20);
            this.tb_cpf.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(379, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(296, 37);
            this.label16.TabIndex = 34;
            this.label16.Text = "Cadastrar Empresa";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(394, 415);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "Consultar Empresa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CadastrarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_nomeproprietario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_naturezajuridica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rb_pe);
            this.Controls.Add(this.rb_gra);
            this.Controls.Add(this.rb_me);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rb_filial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rb_matriz);
            this.Controls.Add(this.tb_nomefantasia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_capitalsocial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mb_telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_regime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_razaosocial);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_situacaocadastral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_situacaocadastral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.TextBox tb_razaosocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_regime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mb_telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_capitalsocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nomefantasia;
        private System.Windows.Forms.RadioButton rb_matriz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rb_filial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_me;
        private System.Windows.Forms.RadioButton rb_gra;
        private System.Windows.Forms.RadioButton rb_pe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_naturezajuridica;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_nomeproprietario;
        private System.Windows.Forms.MaskedTextBox tb_cpf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}