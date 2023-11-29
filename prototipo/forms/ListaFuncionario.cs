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
    public partial class ListaFuncionario : Form
    {
        List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public ListaFuncionario()
        {
            InitializeComponent();
            Consultar();
        }
        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM funcionario");
                var leitor = comando.ExecuteReader();
                

                while (leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.Id = leitor.GetInt32("id_fun");
                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    funcionario.Data_nas = DAOHelper.GetDateTime(leitor, "data_nascimento_fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_fun");
                    funcionario.Rua = DAOHelper.GetString(leitor, "rua_fun");
                    funcionario.Bairro = DAOHelper.GetString(leitor, "bairro_fun");
                    funcionario.Numero = leitor.GetInt32("numero_fun");
                    funcionario.Pais = DAOHelper.GetString(leitor, "pais_fun");
                    funcionario.Estado_civil = DAOHelper.GetString(leitor, "estado_civil_fun");
                    funcionario.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_fun");

                    listaFuncionarios.Add(funcionario);
                }
                dataGridViewFuncionario.DataSource = listaFuncionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFun d = new CadastrarFun();
            d.Visible = true;
            this.Visible = false;
            
        
        }
    }
}
