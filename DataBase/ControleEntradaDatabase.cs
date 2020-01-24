using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class ControleEntradaDatabase
    {
        Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
        public void InserirControleEntrada(Entity.tb_controle_entrada entrada)
        {
            db.tb_controle_entrada.Add(entrada);

            db.SaveChanges();
        }
        public List<Entity.tb_controle_entrada> ListarTodos()
        {
            List<Entity.tb_controle_entrada> entrada = db.tb_controle_entrada.ToList();
            return entrada;
        }
		//public List<Entity.tb_controle_entrada> ConsultarControleDeEntrada(string control)
		//{
		//	List<Entity.tb_controle_entrada> controle
		//		= db.tb_controle_entrada.Where(x => x.nm_nome.Contains(control)).ToList();
		//	return controle;

		//}
		public void RemoverControleEntrada(int id)
		{
			Entity.tb_controle_entrada controle = db.tb_controle_entrada.FirstOrDefault(x => x.id_controle_entrada== id);
			db.tb_controle_entrada.Remove(controle);
			db.SaveChanges();
		}
		public void AlterarControleDeEntrada(Entity.tb_controle_entrada controle)
		{
			Entity.tb_controle_entrada controleAlterar = db.tb_controle_entrada.FirstOrDefault(x => x.id_controle_entrada == controle.id_controle_entrada);

			controleAlterar.id_controle_entrada= controle.id_controle_entrada;
			controleAlterar.id_produto = controle.id_produto;
			controleAlterar.qtd_entrada = controle.qtd_entrada;
			controleAlterar.tb_produto = controle.tb_produto;
			
			db.SaveChanges();

		}
	}
}
