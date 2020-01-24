using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DataBase.Entity;

namespace TCC.Business
{
    class FornecedorBusiness
    {
        DataBase.FornecedorDatabase database = new DataBase.FornecedorDatabase();

        public void Inserir(tb_fornecedor fornecedor)
        {
            if (fornecedor.nm_fornecedor == string.Empty)
            {
                throw new ArgumentException("O nome precisa estar completo");
            }

            bool existe_cnjp = this.CNPJ(fornecedor.nr_cnpj);

            if (!existe_cnjp)
            {
                throw new ArgumentException("CNPJ invalido!!");

            }
            if(fornecedor.nr_cnpj == "00.000.000/0000-00")
            {
                throw new ArgumentException("CNPJ rejeitado pela Receita Federal.");
            }

            bool existenobanco = database.ExisteCNPJ(fornecedor);

            if (existenobanco)
                throw new ArgumentException("CNPJ já cadastrado no sistema");


            database.Inserir(fornecedor);
        }

        public void AlterarFornecedor(DataBase.Entity.tb_fornecedor fornecedor)
        {
            database.Alterar(fornecedor);
        }

        public List<DataBase.Entity.tb_fornecedor> ListarTodos()
        {
            List<DataBase.Entity.tb_fornecedor> fornecedor = database.ListarTodos();

            return fornecedor;
        }

        public List<DataBase.Entity.tb_fornecedor> ConsultarPorNomeFornecedor(string nome)
        {
            List<DataBase.Entity.tb_fornecedor> fornecedor = database.ConsultarPorNomeFornecedor(nome);

            return fornecedor;
        }

        public void Remover(DataBase.Entity.tb_fornecedor fornecedor)
        {
            database.Remover(fornecedor);
        }
        
        public void InserirForncedor(DataBase.Entity.tb_fornecedor fornecedor)
        {
          
        }
        public bool CNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }


    }
    
}

