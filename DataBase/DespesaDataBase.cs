using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class DespesaDataBase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirDespesas(Entity.tb_despesa despesa)
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
			db.tb_despesa.Add(despesa);
			db.SaveChanges();

		}

		public List<Entity.tb_despesa> ListarTodos()
		{
			List<Entity.tb_despesa> despesas = db.tb_despesa.ToList();
			return despesas;
		}

		public List<Entity.tb_despesa> ConsultarPorNomeDespesa(string nome)
		{
			List<Entity.tb_despesa> despesa
				= db.tb_despesa.Where(x => x.tp_despesa.Contains(nome)).ToList();
			return despesa;

		}
		public void RemoverDespesa(int id)
		{
			Entity.tb_despesa despesa = db.tb_despesa.FirstOrDefault(x => x.id_despesa == id);
			db.tb_despesa.Remove(despesa);
			db.SaveChanges();
		}
		//public void AlterarDespesas(Entity.tb_despesa despesa)
		//{
		//	Entity.tb_despesa despesaAlterar = db.tb_despesa.FirstOrDefault(x => x.id_cliente == cliente.id_cliente);

		//	despesa.id_despesa = despesa.id_despesa;
		//	despesa.dt_pagamento = despesa.dt_pagamento;
		//	despesa.dt_vencimento = despesa.dt_vencimento;
		//	despesa.tp_despesa = despesa.tp_despesa;
		//	despesa.vl_despesa = despesa.vl_despesa;

		//	db.SaveChanges();

		//}
	}
}
