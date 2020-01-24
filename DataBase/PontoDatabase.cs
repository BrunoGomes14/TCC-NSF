using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class PontoDatabase
    {
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
		public void InserirPonto(Entity.tb_ponto ponto)
		{
			db.tb_ponto.Add(ponto);

			db.SaveChanges();
		}
		public List<Entity.tb_ponto> ListarTodos()
		{
			List<Entity.tb_ponto> ponto = db.tb_ponto.ToList();
			return ponto;
		}

		public List<Entity.tb_ponto> ConsultarPorNomePonto(Entity.tb_ponto pontos)
		{
		  List<Entity.tb_ponto> ponto =
		  db.tb_ponto.Where(y => y.id_ponto == pontos.id_ponto).ToList();
			return ponto;
		}
		public void RemoverPonto(int id)
		{
			Entity.tb_ponto ponto = db.tb_ponto.FirstOrDefault(y => y.id_ponto == id);

			db.tb_ponto.Remove(ponto);
			db.SaveChanges();
		}
		public void AlterarPonto(Entity.tb_ponto ponto)
		{
			Entity.tb_ponto alterar =
				db.tb_ponto.FirstOrDefault(y => y.id_ponto == ponto.id_ponto);
			alterar.id_ponto = ponto.id_ponto;
			alterar.id_funcionario = ponto.id_funcionario;
			alterar.dt_entrada = ponto.dt_entrada;
			alterar.dt_saida = ponto.dt_saida;
			alterar.hr_saida_intervalo = ponto.hr_saida_intervalo;
			alterar.hr_volta_intervalo = ponto.hr_volta_intervalo;
			alterar.tb_funcionario = ponto.tb_funcionario;

			db.SaveChanges();
		}
	}
}
