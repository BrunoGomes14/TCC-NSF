using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class FuncionarioDataBase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirFuncionario(Entity.tb_funcionario funcionario)
		{
			int id = db.tb_funcionario.Add(funcionario).id_funcionario;

			db.SaveChanges();
		}
		public List<Entity.tb_funcionario> ListarTodos()
		{
			List<Entity.tb_funcionario> funcionario = db.tb_funcionario.ToList();
			return funcionario;
		}

		public List<Entity.tb_funcionario> ConsultarPorNomeFuncionario(string nome)
		{
			List<Entity.tb_funcionario> funcionario =
				db.tb_funcionario.Where(y => y.nm_nome.Contains(nome)).ToList();
			return funcionario;
		}
        public List<Entity.tb_funcionario> ConsultarPorSobrenome(string sobrenome)
        {
            List<Entity.tb_funcionario> funcionario =
                db.tb_funcionario.Where(y => y.nm_sobrenome.Contains(sobrenome)).ToList();
            return funcionario;
        }
        public List<Entity.tb_funcionario> ConsultarPorGenero(string genero)
        {
            List<Entity.tb_funcionario> funcionario =
                db.tb_funcionario.Where(y => y.tp_genero.Contains(genero)).ToList();
            return funcionario;
        }

        public void RemoverFuncionario(int id)
		{
			Entity.tb_funcionario funcionario = db.tb_funcionario.FirstOrDefault(y => y.id_funcionario == id);

			db.tb_funcionario.Remove(funcionario);
			db.SaveChanges();
		}
		public void AlterarFuncionario(Entity.tb_funcionario funcionario)
		{
			Entity.tb_funcionario alterar =
				db.tb_funcionario.FirstOrDefault(y => y.id_funcionario == funcionario.id_funcionario);
			alterar.id_funcionario = funcionario.id_funcionario;
			alterar.nm_nome = funcionario.nm_nome;
			alterar.dt_admissao = funcionario.dt_admissao;
			alterar.nm_sobrenome = funcionario.nm_sobrenome;
			alterar.nr_cpf = funcionario.nr_cpf;
			alterar.nr_rg = funcionario.nr_rg;
			alterar.tb_cargo = funcionario.tb_cargo;
			alterar.tb_desc_funcionario = funcionario.tb_desc_funcionario;
			alterar.tb_falta = funcionario.tb_falta;
			alterar.tb_folha_pagamento = funcionario.tb_folha_pagamento;
			alterar.tb_jornada= funcionario.tb_jornada;
			alterar.tb_ponto = funcionario.tb_ponto;
			alterar.tb_salario = funcionario.tb_salario;
			alterar.tp_genero = funcionario.tp_genero;
			

			db.SaveChanges();
		}
        public Entity.tb_funcionario FuncionarioId(int id )
        {
            
            Entity.tb_funcionario mod = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id);

            return mod;
        }
        public bool ExisteCPF(DataBase.Entity.tb_funcionario funcionario)
        {
            bool existe = db.tb_funcionario.Any(x => x.nr_cpf == funcionario.nr_cpf);

            return existe;
        }
        //public List<DataBase.Entity.tb_funcionario> ConsultarFuncionarioChave(int id)
        //{
           
        //}

    }
}
