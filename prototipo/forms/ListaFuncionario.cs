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
    public partial class ListaFuncionario : Form
    {
        public ListaFuncionario()
        {
            InitializeComponent();
        }

        private void ListaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFun d = new CadastrarFun();
            this.Visible = false;
            d.ShowDialog();
        
        }
    }
}
