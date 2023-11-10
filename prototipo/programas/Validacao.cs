using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

public static class Validacao
{
    public static bool CPF(string cpf)
    {
        // tira o ponto e o traço do cpf
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        //esta verificando se tem 11 digitos do cpf
        if (cpf.Length != 11)
        {
            return false;
        }

        // esta fazendo a multiplicação de cada numero do cpf para a  verificação.
        int p = Convert.ToInt32(cpf[0].ToString()) * 10;
        int p2 = Convert.ToInt32(cpf[1].ToString()) * 9;
        int p3 = Convert.ToInt32(cpf[2].ToString()) * 8;
        int p4 = Convert.ToInt32(cpf[3].ToString()) * 7;
        int p5 = Convert.ToInt32(cpf[4].ToString()) * 6;
        int p6 = Convert.ToInt32(cpf[5].ToString()) * 5;
        int p7 = Convert.ToInt32(cpf[6].ToString()) * 4;
        int p8 = Convert.ToInt32(cpf[7].ToString()) * 3;
        int p9 = Convert.ToInt32(cpf[8].ToString()) * 2;

        // int CPFZAO esta somando o resultado final da multiplicação de cada numero para a verificação
        // o reultado que der vai ser ultilizado no int restofinal e fazer a porcentagem de 11 para a verificação.
        int CPFZAO = p + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;
        int restofinal = CPFZAO % 11;

        //ta conferindo se o restofinal é menor que 2.
        if (restofinal < 2)
        {
            // se ele for diferente ou igual a 0 vai retornar falso ou "false".
            if (Convert.ToInt32(cpf[9].ToString()) != 0)
            {
                return false;
            }
        }

        //esta conferindo se o restofinal é igual ou maior que 2.
        else if (restofinal >= 2)
        {
            //ta conferindo o primeiro digito verificando se é igual ou diferente de 11 menos o restofinal,
            //se ele for diferente do numero digitado do cpf vai retornar falso ou "false".
            if (Convert.ToInt32(cpf[9].ToString()) != 11 - restofinal)
            {
                return false;
            }
        }

        //esta multiplicando os numeros do cpf para a segunda verificação.
        int t0 = Convert.ToInt32(cpf[0].ToString()) * 11;
        int t1 = Convert.ToInt32(cpf[1].ToString()) * 10;
        int t2 = Convert.ToInt32(cpf[2].ToString()) * 9;
        int t3 = Convert.ToInt32(cpf[3].ToString()) * 8;
        int t4 = Convert.ToInt32(cpf[4].ToString()) * 7;
        int t5 = Convert.ToInt32(cpf[5].ToString()) * 6;
        int t6 = Convert.ToInt32(cpf[6].ToString()) * 5;
        int t7 = Convert.ToInt32(cpf[7].ToString()) * 4;
        int t8 = Convert.ToInt32(cpf[8].ToString()) * 3;
        int t9 = Convert.ToInt32(cpf[9].ToString()) * 2;

        // int CPFZAO2 esta somando o resultado final da multiplicação de cada numero para a verificação
        // o reultado que der vai ser ultilizado no int calcufinal e fazer a porcentagem de 11 para a verificação.
        int CPFZAO2 = t0 + t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9;
        int calcufinal = CPFZAO2 % 11;

        //ta conferindo se o restofinal é menor que 2.
        if (calcufinal < 2)
        {
            // se ele for diferente ou igual a 0 vai retornar falso ou "false".
            if (Convert.ToInt32(cpf[10].ToString()) != 0)
            {
                return false;
            }
        }

        //esta conferindo se o restofinal é igual ou maior que 2.
        else if (calcufinal >= 2)
        {
            //ta conferindo o primeiro digito verificando se é igual ou diferente de 11 menos o restofinal,
            //se ele for diferente do numero digitado do cpf vai retornar falso ou "false".
            if (Convert.ToInt32(cpf[10].ToString()) != 11 - calcufinal)
            {
                return false;
            }
        }
        //se nenhum dos if e else if derem false, o numero digitado do cpf é verdadeiro.
        return true;
    }
}

