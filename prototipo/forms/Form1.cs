using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form2 a = new Form2();
            this.Visible = false;
            this.Visible = true;
            
            
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_email.Clear();
            tb_nome.Clear();
            mt_dataNasc.Clear();
            mt_cpf.Clear();
            mt_rg.Clear();
            mt_telefone.Clear();
            tb_rua.Clear();
            tb_bairro.Clear();
            tb_numero.Clear();
            tb_cidade.Clear();
            tb_estado.Clear();
            tb_pais.Clear();
            tb_funcao.Clear();
            tb_salario.Clear();
        }

        private void mt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string cpf = mt_cpf.Text;
            bool resulcpf = Validacao.CPF(cpf);
            MessageBox.Show(resulcpf.ToString());
            MessageBox.Show(tb_email.Text);
            MessageBox.Show(tb_nome.Text);
            MessageBox.Show(mt_dataNasc.Text);
            MessageBox.Show(mt_cpf.Text);
            MessageBox.Show(mt_rg.Text);
            MessageBox.Show(mt_telefone.Text);
            MessageBox.Show(tb_rua.Text);
            MessageBox.Show(tb_bairro.Text);                                                                                                                                                                                                                                                        
            MessageBox.Show(tb_numero.Text);
            MessageBox.Show(tb_cidade.Text);
            MessageBox.Show(tb_estado.Text);
            MessageBox.Show(tb_pais.Text);
            MessageBox.Show(tb_funcao.Text);
            MessageBox.Show(tb_salario.Text);

        }
    }
    
}
