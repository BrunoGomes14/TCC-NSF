using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class SalarioDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
		public void InserirSalario(Entity.tb_salario salario)
		{
			db.tb_salario.Add(salario);

			db.SaveChanges();
		}
		public List<Entity.tb_salario> ListarTodos()
		{
			List<Entity.tb_salario> salario = db.tb_salario.ToList();
			return salario;
		}

		public List<Entity.tb_salario> ConsultarPorNomeSalario(Entity.tb_salario salarios)
		{
			List<Entity.tb_salario> salario =
				db.tb_salario.Where(y => y.id_salario == salarios.id_salario).ToList();
			return salario;
		}
		public void RemoverSalario(int id)
		{
			Entity.tb_salario salario = db.tb_salario.FirstOrDefault(y => y.id_salario == id);

			db.tb_salario.Remove(salario);
			db.SaveChanges();
		}
		public void AlterarSalario(Entity.tb_salario salario)
		{
			Entity.tb_salario alterar =
				db.tb_salario.FirstOrDefault(y => y.id_salario == salario.id_salario);
			alterar.id_salario = salario.id_salario;
			alterar.id_funcionario = salario.id_funcionario;
			alterar.tb_funcionario = salario.tb_funcionario;
			alterar.vl_salario_bruto = salario.vl_salario_bruto;

			db.SaveChanges();
		}
	}
}
