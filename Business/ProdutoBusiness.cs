using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DataBase.Entity;

namespace TCC.Business
{
    class ProdutoBusiness
    {
        DataBase.ProdutoDatabase database = new DataBase.ProdutoDatabase();

        public void Inserir(tb_produto produto)
        {
           

       
            database.CadastrarProduto(produto);
        }

        public void Alterar(tb_produto produto)
        {
            database.Alterar(produto);
        }

        public void Remover(tb_produto produto)
        {
            database.Remover(produto);
        }

        public List<tb_produto> ConsultarTodos()
        {
            List<tb_produto> produtos = database.ConsultarTodos();

            return produtos;
        }

        public List<DataBase.Entity.tb_produto> ConsultarPorNome(string nome)
        {
           List< DataBase.Entity.tb_produto> produto = database.ConsultarPorNome(nome);

            return produto;
        }

        public DataBase.Entity.tb_produto ConsultarPorModelo(string modelo)
        {
            DataBase.Entity.tb_produto produto = database.ConsultarPorModelo(modelo);

            return produto;
        }

        public DataBase.Entity.tb_produto ConsultarPorCor(string cor)
        {
            DataBase.Entity.tb_produto produto = database.ConsultarPorCor(cor);

            return produto;
        }

        public DataBase.Entity.tb_produto ConsultarPorMarca(string marca)
        {
            DataBase.Entity.tb_produto produto = database.ConsultarPorMarca(marca);

            return produto;
        }

        public DataBase.Entity.tb_produto ConsultarPorTipo(string tipo)
        {
            DataBase.Entity.tb_produto produto = database.ConsultarPorTipo(tipo);

            return produto;
        }





    }
}