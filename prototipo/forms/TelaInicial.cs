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
            CadastrarFun a = new CadastrarFun();
            this.Visible = false;
            this.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa b = new CadastrarEmpresa();
            this.Visible = false;
            b.ShowDialog();
            this.Visible = true;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
