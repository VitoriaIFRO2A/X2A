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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CadastrarFun abrirForms = new CadastrarFun();
             this.Visible = false;
             abrirForms.Visible = false;
             abrirForms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa b = new CadastrarEmpresa();
            this.Visible = false;
            b.ShowDialog();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
