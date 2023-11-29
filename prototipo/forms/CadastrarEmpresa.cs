using CadastroFuncionario;
using prototipo.programas;
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
        void Inserir(Empresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Empresa  VALUES (@id, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @regime_tributario, @data_inicio, @telefone, @capita_social, @endereco_completo, @estado, @tipo, @porte_empresa, @natureza_juridica, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
                comando.Parameters.AddWithValue("@razao_social", empresa.Razao_social);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.Nome_fantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.Situacao_cadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.Regime_tributario);
                comando.Parameters.AddWithValue("@data_inicio", empresa.Data_inicio_atividade);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capita_social", empresa.Capital_social);
                comando.Parameters.AddWithValue("@endereco_completo", empresa.Endereco_completo);
                comando.Parameters.AddWithValue("@estado", empresa.Estado);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte_empresa", empresa.Porte_empresa);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.Natureza_juridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.Nome_proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.CPF_proprietario);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaEmpresa c = new ListaEmpresa();
            this.Visible = false;
            c.Visible = true;

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
            try
            {
                string cnpj = tb_cnpj.Text;
                string razaoSocial = tb_razaosocial.Text;
                string nomeFantasia = tb_nomefantasia.Text;
                string situacaoCadastral = cb_situacaocadastral.Text;
                string regimeTributario = groupBox3.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                DateTime data_inicio = Convert.ToDateTime(dateTimePicker1.Text);
                string telefone = mb_telefone.Text;
                double capital_social = Convert.ToDouble(tb_capitalsocial.Text);
                string endereco_completo = tb_endereco.Text;
                string estado = cb_estado.Text;
                string tipo = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string porte_empresa = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string natureza_juridica = cb_naturezajuridica.Text;
                string nome_proprietario = tb_nomeproprietario.Text;
                string cpf_proprietario = tb_cpf.Text;
                if (Validacao.CPF(cpf_proprietario) == false)
                {
                    MessageBox.Show("CPF inválido");
                }

                Empresa empresa = new Empresa(cnpj, razaoSocial, nomeFantasia, situacaoCadastral, regimeTributario, data_inicio, telefone, capital_social, endereco_completo, estado, tipo, porte_empresa, natureza_juridica, nome_proprietario, cpf_proprietario);
                Inserir(empresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rb_matriz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaInicial abrir = new TelaInicial();
            abrir.Visible = true;
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
