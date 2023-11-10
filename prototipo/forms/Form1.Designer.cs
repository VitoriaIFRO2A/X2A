namespace prototipo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mt_rg = new System.Windows.Forms.MaskedTextBox();
            this.mt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mt_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO FUNCIONARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.lb_Resultado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mt_telefone);
            this.panel1.Controls.Add(this.mt_rg);
            this.panel1.Controls.Add(this.mt_cpf);
            this.panel1.Controls.Add(this.mt_dataNasc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 168);
            this.panel1.TabIndex = 2;
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(408, 96);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(16, 13);
            this.lb_Resultado.TabIndex = 17;
            this.lb_Resultado.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "DADOS PESSOAL";
            // 
            // mt_telefone
            // 
            this.mt_telefone.Location = new System.Drawing.Point(695, 62);
            this.mt_telefone.Mask = "(00) 00000-0000";
            this.mt_telefone.Name = "mt_telefone";
            this.mt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mt_telefone.TabIndex = 15;
            // 
            // mt_rg
            // 
            this.mt_rg.Location = new System.Drawing.Point(394, 130);
            this.mt_rg.Mask = "00,000,000-00";
            this.mt_rg.Name = "mt_rg";
            this.mt_rg.Size = new System.Drawing.Size(100, 20);
            this.mt_rg.TabIndex = 14;
            // 
            // mt_cpf
            // 
            this.mt_cpf.Location = new System.Drawing.Point(394, 57);
            this.mt_cpf.Mask = "000,000,000-00";
            this.mt_cpf.Name = "mt_cpf";
            this.mt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mt_cpf.TabIndex = 13;
            this.mt_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mt_cpf_MaskInputRejected);
            // 
            // mt_dataNasc
            // 
            this.mt_dataNasc.Location = new System.Drawing.Point(153, 125);
            this.mt_dataNasc.Mask = "00/00/0000";
            this.mt_dataNasc.Name = "mt_dataNasc";
            this.mt_dataNasc.Size = new System.Drawing.Size(100, 20);
            this.mt_dataNasc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "EMAIL:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(638, 134);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(157, 20);
            this.tb_email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "TELEFONE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = " NASCIMENTO:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(96, 52);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(157, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOME:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.tb_pais);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.tb_estado);
            this.panel2.Controls.Add(this.tb_cidade);
            this.panel2.Controls.Add(this.tb_bairro);
            this.panel2.Controls.Add(this.tb_rua);
            this.panel2.Controls.Add(this.tb_numero);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 129);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(627, 90);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(142, 20);
            this.tb_pais.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(528, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 24);
            this.label15.TabIndex = 27;
            this.label15.Text = "PAIS:";
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(627, 56);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(142, 20);
            this.tb_estado.TabIndex = 24;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(371, 91);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(134, 20);
            this.tb_cidade.TabIndex = 26;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(108, 91);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(145, 20);
            this.tb_bairro.TabIndex = 25;
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(77, 49);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(176, 20);
            this.tb_rua.TabIndex = 24;
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(371, 51);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(134, 20);
            this.tb_numero.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(528, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "ESTADO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "CIDADE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(266, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "NUMERO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "BAIRRO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "RUA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "ENDEREÇO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.cb_estadoCivil);
            this.panel3.Controls.Add(this.tb_salario);
            this.panel3.Controls.Add(this.tb_funcao);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(31, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 110);
            this.panel3.TabIndex = 4;
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.FormattingEnabled = true;
            this.cb_estadoCivil.Items.AddRange(new object[] {
            "CASADO(A)",
            "SOLTEIRO(A)",
            "VIUVO(A)",
            "NAMORANDO"});
            this.cb_estadoCivil.Location = new System.Drawing.Point(666, 57);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoCivil.TabIndex = 6;
            // 
            // tb_salario
            // 
            this.tb_salario.Location = new System.Drawing.Point(394, 56);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(111, 20);
            this.tb_salario.TabIndex = 5;
            // 
            // tb_funcao
            // 
            this.tb_funcao.Location = new System.Drawing.Point(108, 56);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(180, 20);
            this.tb_funcao.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(518, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 24);
            this.label19.TabIndex = 3;
            this.label19.Text = "ESTADO CIVIL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(303, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "SALARIO:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "FUNÇÃO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(292, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "DADOS EMPRESARIAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(160, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(563, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(862, 590);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mt_dataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_estadoCivil;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mt_telefone;
        private System.Windows.Forms.MaskedTextBox mt_rg;
        private System.Windows.Forms.MaskedTextBox mt_cpf;
        private System.Windows.Forms.Label lb_Resultado;
    }
}

