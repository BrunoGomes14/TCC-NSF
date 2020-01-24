using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class FolhaPagamentoDatabase
    {
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirFolhaDePagamento(Entity.tb_folha_pagamento folha)
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
			db.tb_folha_pagamento.Add(folha);
			db.SaveChanges();

		}

		public List<Entity.tb_folha_pagamento> ListarTodos()
		{
			List<Entity.tb_folha_pagamento> folha = db.tb_folha_pagamento.ToList();
			return folha;
		}

		//public List<Entity.tb_folha_pagamento> ConsultarPorNomeFolha(string nome)
		//{
			//List<Entity.tb_folha_pagamento> pagamento
			//	//= db.tb_folha_pagamento.Where(x => x..Contains(nome)).ToList();
			//return pagamento;

		//}
		public void RemoverFolhaDePagamento(int id)
		{
			Entity.tb_folha_pagamento folha = db.tb_folha_pagamento.FirstOrDefault(x => x.id_folha_pagamento == id);
			db.tb_folha_pagamento.Remove(folha);
			db.SaveChanges();
		}
		public void AlterarFolhaDePagamento(Entity.tb_folha_pagamento folha)
		{
			Entity.tb_folha_pagamento pagamento = db.tb_folha_pagamento.FirstOrDefault(x => x.id_folha_pagamento == folha.id_folha_pagamento);

			pagamento.id_folha_pagamento = folha.id_folha_pagamento;
			pagamento.id_funcionario = folha.id_funcionario;
			pagamento.tb_funcionario = folha.tb_funcionario;
			pagamento.hr_extra = folha.hr_extra;
			pagamento.vl_salario_bruto= folha.vl_salario_bruto;
			pagamento.vl_salario_liquido= folha.vl_salario_liquido;
			db.SaveChanges();

		}
        public Entity.tb_funcionario Funcionario(Entity.tb_funcionario funcionario)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

            Entity.tb_funcionario fun = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == funcionario.id_funcionario);

            return fun;

        }
        public decimal SalarioFuncionario(int id)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            decimal salario = Convert.ToDecimal(db.tb_salario.FirstOrDefault(x => x.id_funcionario == id).vl_salario_bruto) ;

            return salario;
        }
        public bool VerficarExistencia(int id)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            bool e = db.tb_salario.Any(a => a.id_funcionario == id);
            return e;
        }
        public int FaltasFuncionario(int id, DateTime mes)
        {
            int falso = 0;
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            int faltas = db.tb_falta.Where(x => x.id_funcionario == id
                                             && x.dt_falta.Value.Month == mes.Month
                                             && x.bl_falta_justificada == false
                                          ).ToList().Count();

            return faltas;
        }
        public bool ConsultarExistenciaDeFolha(Entity.tb_folha_pagamento folha)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            bool existe = db.tb_folha_pagamento.Any(x => x.id_funcionario == folha.id_funcionario &&
                                                         x.dt_referente_mes.Month == folha.dt_referente_mes.Month);

            return existe;
        }
        
	}
}
