using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? Data_nas { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Estado_civil { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Pais { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, DateTime data_nas, string cpf, string rg, string telefone, string email, string estado_civil, string funcao, double salario, string estado, string cidade, string rua, int numero, string bairro, string pais)
        {
            Nome = nome;
            Data_nas = data_nas;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            Estado_civil = estado_civil;
            Funcao = funcao;
            Salario = salario;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Pais = pais;
        }
    }
}