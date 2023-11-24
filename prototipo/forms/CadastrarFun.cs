using CadastroFuncionario;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prototipo
{
    public partial class CadastrarFun : Form
    {
        public CadastrarFun()
        {
            TelaInicial a = new TelaInicial();
            this.Visible = false;
            this.Visible = true;
            

            
            InitializeComponent();
        }

        void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (@id, @nome, @data_nascimento, @cpf, @rg, @telefone, @email, @estado_civil, @funcao, @salario, @estado, @cidade, @rua, @numero, @bairro, @pais)");
                //nome, data_nas, cpf, rg, telefone, email, estado_civil, funcao, salario, estado, cidade, rua, numero, bairro, pais.
                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nascimento", funcionario.Data_nas);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_civil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@rua", funcionario.Rua);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                comando.Parameters.AddWithValue("@pais", funcionario.Pais);

                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }

             catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }


        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM funcionario");
                var leitor = comando.ExecuteReader();
                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_func");
                }

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {


                string nome = tb_nome.Text;
                string cpf = mt_cpf.Text;
                if (Validacao.CPF(cpf) == false)
                {
                    lb_Resultado.Text = "CPF não passou na verificação";
                }
                string telefone = mt_telefone.Text;
                DateTime Data_nascimento = Convert.ToDateTime(mt_dataNasc.Text);
                string rg = mt_rg.Text;
                string email = tb_email.Text;

                string rua = tb_rua.Text;
                int numero = Convert.ToInt32(tb_numero.Text);
                string estado = tb_estado.Text;
                string bairro = tb_bairro.Text;
                string cidade = tb_cidade.Text;
                string pais = tb_pais.Text;
                string funcao = tb_funcao.Text;
                double salario = Convert.ToDouble(tb_salario.Text);
                string estado_civil = cb_estadoCivil.Text;

                Funcionario funcionario = new Funcionario(nome, Data_nascimento, cpf, rg, telefone, email, estado_civil, funcao, salario, estado, cidade, rua, numero, bairro, pais);

                Inserir(funcionario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Visible = false;
            telaInicial.ShowDialog();
            this.Visible = true;
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
