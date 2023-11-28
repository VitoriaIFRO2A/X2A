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
    public partial class CadastrarEmpresa : Form
    {
        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaEmpresa c = new ListaEmpresa();
            this.Visible = false;
            c.ShowDialog();
            this.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_cnpj.Clear();
            tb_razaosocial.Clear();
            tb_nomefantasia.Clear();
            mb_telefone.Clear();
            tb_capitalsocial.Clear();
            tb_endereco.Clear();
            tb_nomeproprietario.Clear();
            tb_cpf.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
