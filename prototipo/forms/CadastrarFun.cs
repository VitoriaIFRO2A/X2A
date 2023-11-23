using CadastroFuncionario;
using System;
using System.Collections.Generic;
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
                var comando = conexao.Comando("INSERT INTO funcionario VALUES (@id, @nome, @data_nascimento, @cpf, @rg, @telefone, @email, @endereco, @estado_civil, @funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nascimento", funcionario.Data_nas);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_civil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

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

            string cpf = mt_cpf.Text;
            bool resulcpf = Validacao.CPF(cpf);
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

            Inserir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Visible = false;
            telaInicial.ShowDialog();
            this.Visible = true;
        }
    }
    
}
