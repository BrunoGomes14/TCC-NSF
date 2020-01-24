using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class VendaDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
		public void InserirVenda(Entity.tb_venda_registro venda)
		{
			db.tb_venda_registro.Add(venda);
			db.SaveChanges();
		}
        public void InserirVendaDesc(Entity.tb_desc_venda venda)
        {
            db.tb_desc_venda.Add(venda);
            db.SaveChanges();
        }
        public List<Entity.tb_venda_registro> ListarTodos()
		{
			List<Entity.tb_venda_registro> venda = db.tb_venda_registro.ToList();
			return venda;
		}

		//public List<Entity.tb_venda_registro> ConsultarPorNomeVenda(string nome)
		//{
			//List<Entity.tb_venda_registro> venda =
				//db.tb_venda_registro.Where(y => y..Contains(nome)).ToList();
			//return venda;
		//}
		public void RemoverVenda(int id)
		{
			Entity.tb_venda_registro venda = db.tb_venda_registro.FirstOrDefault(y => y.id_venda == id);

			db.tb_venda_registro.Remove(venda);
			db.SaveChanges();
		}
		public void AlterarVenda(Entity.tb_venda_registro venda)
		{
			Entity.tb_venda_registro alterar =
				db.tb_venda_registro.FirstOrDefault(y => y.id_venda == venda.id_venda);
			alterar.id_venda = venda.id_venda;
			alterar.id_cliente = venda.id_cliente;
			alterar.tb_cliente = venda.tb_cliente;
			alterar.tb_desc_venda = venda.tb_desc_venda;
			alterar.tp_pagamento = venda.tp_pagamento;
			alterar.vl_venda = venda.vl_venda;

			db.SaveChanges();
		}
	}
}
