using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
	class FaltaDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirFalta(Entity.tb_falta falta)
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
			db.tb_falta.Add(falta);
			db.SaveChanges();

		}

		public List<Entity.tb_falta> ListarTodos()
		{
			List<Entity.tb_falta> falta = db.tb_falta.ToList();
			return falta;
		}

		public List<Entity.tb_falta> ConsultarPorNomeFalta(Entity.tb_falta faltas)
		{
		        List<Entity.tb_falta> falta
				= db.tb_falta.Where(x => x.id_falta == faltas.id_falta).ToList();
			return falta;

		}
		public void RemoverFalta(int id)
		{
			Entity.tb_falta falta = db.tb_falta.FirstOrDefault(x => x.id_falta == id);
			db.tb_falta.Remove(falta);
			db.SaveChanges();
		}
		public void AlterarFalta(Entity.tb_falta falta)
		{
			Entity.tb_falta faltaAlterar = db.tb_falta.FirstOrDefault(x => x.id_falta == falta.id_falta);

			faltaAlterar.id_falta = falta.id_falta;
			faltaAlterar.id_funcionario = falta.id_funcionario;
			faltaAlterar.tb_funcionario = falta.tb_funcionario;
			faltaAlterar.bl_falta_justificada = falta.bl_falta_justificada;
			faltaAlterar.dt_falta = falta.dt_falta;
            faltaAlterar.ds_justificativa = falta.ds_justificativa;


            db.SaveChanges();
            
		}
        public bool ExisteFalta(Entity.tb_falta falta)
        {
            bool existe = db.tb_falta.Any(x => x.id_funcionario == falta.id_funcionario
                                      && x.dt_falta.Value.Date == falta.dt_falta.Value.Date);

            return existe;
        }
        public bool ExisteFaltaTotal(int id )
        {
            bool existe = db.tb_falta.Any(x => x.id_funcionario == id);
                                     

            return existe;
        }
    }
}
