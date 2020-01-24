using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class JornadaDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
		public void InserirJornada(Entity.tb_jornada jornada)
		{
			db.tb_jornada.Add(jornada);

			db.SaveChanges();
		}
		public List<Entity.tb_jornada> ListarTodos()
		{
			List<Entity.tb_jornada> jornada = db.tb_jornada.ToList();
			return jornada;
		}

		public List<Entity.tb_jornada> ConsultarPorNomeJornada(Entity.tb_jornada jornadas)
		{
			List<Entity.tb_jornada> jornada =
				db.tb_jornada.Where(y => y.id_funcionario == jornadas.id_funcionario).ToList();
			return jornada;
		}
		public void RemoverJornada(int id)
		{
			Entity.tb_jornada jornada = db.tb_jornada.FirstOrDefault(y => y.id_jornada == id);

			db.tb_jornada.Remove(jornada);
			db.SaveChanges();
		}
		public void AlterarJornada(Entity.tb_jornada jornada)
		{
			Entity.tb_jornada alterar =
				db.tb_jornada.FirstOrDefault(y => y.id_jornada == jornada.id_jornada);
			alterar.id_jornada = jornada.id_jornada;
			alterar.id_funcionario = jornada.id_funcionario;
			alterar.hr_entrada= jornada.hr_entrada;
			alterar.hr_intervalo = jornada.hr_intervalo;
			alterar.hr_saida = jornada.hr_saida;
			alterar.hr_volta_intervalo = jornada.hr_volta_intervalo;
			alterar.tb_funcionario = jornada.tb_funcionario;
			

			db.SaveChanges();
		}
	}
}
