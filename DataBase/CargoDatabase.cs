using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class CargoDatabase
    {
        Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		
			

		public void InserirCargo (Entity.tb_cargo cargo)
        {
            db.tb_cargo.Add(cargo);

            db.SaveChanges();
        }
        public List<Entity.tb_cargo> ListarTodos()
        {
            List<Entity.tb_cargo> cargo = db.tb_cargo.ToList();
            return cargo;
        }

        public List<Entity.tb_cargo> ConsultarPorNomeCargo(string nome)
        {
            List<Entity.tb_cargo> cargo =
                db.tb_cargo.Where(y => y.tp_cargo.Contains(nome)).ToList();
            return cargo;
        }
        public void RemoverCargo(int id)
        {
            Entity.tb_cargo cargo = db.tb_cargo.FirstOrDefault(y => y.id_cargo == id);

            db.tb_cargo.Remove(cargo);
            db.SaveChanges();
        }
        public void AlterarCargo(Entity.tb_cargo cargo)
        {
            Entity.tb_cargo cargos =
                db.tb_cargo.FirstOrDefault(y => y.id_cargo == cargo.id_cargo);
            cargos.id_cargo = cargo.id_cargo;
            cargos.tp_cargo = cargo.tp_cargo;
            cargos.ds_descricao_cargo = cargo.ds_descricao_cargo;

            db.SaveChanges();
        }
        public Entity.tb_cargo CargoID(int ID)
        {
            Entity.tb_cargo CARGO = db.tb_cargo.FirstOrDefault(X => X.id_cargo == ID);

            return CARGO;

        }
    }
}
