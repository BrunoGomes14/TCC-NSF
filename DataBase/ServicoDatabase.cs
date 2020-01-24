using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class ServicoDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
		public void InserirServico(Entity.tb_servico servico)
		{
			db.tb_servico.Add(servico);

			db.SaveChanges();
		}
		public List<Entity.tb_servico> ListarTodos()
		{
			List<Entity.tb_servico> servico = db.tb_servico.ToList();
			return servico;
		}

		public List<Entity.tb_servico> ConsultarPorNomeServico(string nome)
		{
			List<Entity.tb_servico> servico =
				db.tb_servico.Where(y => y.nm_servico.Contains(nome)).ToList();
			return servico;
		}
		public void RemoverServico(int id)
		{
			Entity.tb_servico servico = db.tb_servico.FirstOrDefault(y => y.id_servico == id);

			db.tb_servico.Remove(servico);
			db.SaveChanges();
		}
		public void AlterarServico(Entity.tb_servico servico)
		{
			Entity.tb_servico alterar =
				db.tb_servico.FirstOrDefault(y => y.id_servico == servico.id_servico);
			alterar.id_servico = servico.id_servico;
			alterar.ds_servico= servico.ds_servico;
			alterar.nm_servico = servico.nm_servico;
			alterar.vl_servico = servico.vl_servico;

			db.SaveChanges();
		}
	}
}
