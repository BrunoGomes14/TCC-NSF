using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class EstoqueDatabase
	{ Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirEstoque(Entity.tb_estoque estoque)
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
			db.tb_estoque.Add(estoque);
			db.SaveChanges();

		}

		public List<Entity.tb_estoque> ListarTodos()
		{
			List<Entity.tb_estoque> estoque = db.tb_estoque.ToList();
			return estoque;
		}

		public List<Entity.tb_estoque> ConsultarPorNomeEstoque(Entity.tb_estoque estoques)
		{
			List<Entity.tb_estoque> estoque
				= db.tb_estoque.Where(x => x.id_estoque == estoques.id_estoque).ToList();
			return estoque;

		}
	     public void RemoverEstoque(int id)
		{
			Entity.tb_estoque estoque = db.tb_estoque.FirstOrDefault(x => x.id_estoque == id);
		    db.tb_estoque.Remove(estoque);
			db.SaveChanges();
		}
		public void AlterarEstoque(Entity.tb_estoque estoque)
		{
			Entity.tb_estoque estoquealterar = db.tb_estoque.FirstOrDefault(x => x.id_estoque == estoque.id_estoque);

			estoquealterar.id_estoque = estoque.id_estoque;
			estoquealterar.id_produto = estoque.id_produto;
			estoquealterar.qtd_produto= estoque.qtd_produto;
			estoquealterar.tb_produto = estoque.tb_produto;
			db.SaveChanges();

		}
	}
}
