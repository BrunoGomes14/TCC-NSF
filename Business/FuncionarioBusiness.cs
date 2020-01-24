using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class FuncionarioBusiness
    {
        public void InserirFuncionario(DataBase.Entity.tb_funcionario funcionario)
        {
            DataBase.FuncionarioDataBase db = new DataBase.FuncionarioDataBase();

            if (funcionario.nm_nome == string.Empty || funcionario.nm_sobrenome == string.Empty)
            {
                throw new ArgumentException("O nome precisa estar completo");
            }

            int cal = DateTime.Now.Year - funcionario.dt_nascimento.Year;

            if (cal <= 16)
            {
                throw new ArgumentException("O funcionário não pode ser menor de idade");

            }

            bool cpfdaora = this.ValidaCPF(funcionario.nr_cpf);

            if(!cpfdaora)
            {
                throw new ArgumentException("CPF invalido");
            }


            bool existe = db.ExisteCPF(funcionario);

            if (existe)
                throw new ArgumentException("CPF já cadastrado no sistema");

            if (funcionario.tp_genero != "M" || funcionario.tp_genero != "F")
                throw new ArgumentException("Gênero não escolhido");

            db.InserirFuncionario(funcionario);


        }
        public bool ValidaCPF(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        
    }
}
