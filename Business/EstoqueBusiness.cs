using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class EstoqueBusiness
    {
        DataBase.EstoqueDatabase database = new DataBase.EstoqueDatabase();

        public void InserirEstoque(DataBase.Entity.tb_estoque estoque)
        {
            if (estoque.id_produto == null || estoque.qtd_produto == null)
            {
                throw new Exception("Este Campo É Obrigatório");
            }

            database.InserirEstoque(estoque);
        }

        public void RemoverEstoque(int id)
        {
            database.RemoverEstoque(id);
        }

        public void AlterarEstoque(DataBase.Entity.tb_estoque estoque)
        {
            database.AlterarEstoque(estoque);
        }

        public List<DataBase.Entity.tb_estoque> ListarTodos()
        {
            List<DataBase.Entity.tb_estoque> estoque = database.ListarTodos();

            return estoque;
        }

        public List<DataBase.Entity.tb_estoque> ConsultarPorNomeEstoque(DataBase.Entity.tb_estoque estoques)
        {
            List<DataBase.Entity.tb_estoque> estoque = database.ConsultarPorNomeEstoque(estoques);

            return estoque;
        }

    }
}
