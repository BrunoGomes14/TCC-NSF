using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DataBase.Entity;

namespace TCC.DataBase
{
    class FornecedorDatabase
	{
		Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void Inserir(Entity.tb_fornecedor fornecedor)
		{
			db.tb_fornecedor.Add(fornecedor);

			db.SaveChanges();
		}
		public List<Entity.tb_fornecedor> ListarTodos()
		{
			List<Entity.tb_fornecedor> fornecedor = db.tb_fornecedor.ToList();
			return fornecedor;
		}

		public List<Entity.tb_fornecedor> ConsultarPorNomeFornecedor(string nome)
		{
			List<Entity.tb_fornecedor> fornecedor =
				db.tb_fornecedor.Where(y => y.nm_fornecedor.Contains(nome)).ToList();
			return fornecedor;
		}
		
        public void Remover (Entity.tb_fornecedor fornecedor)
        {
            Entity.tb_fornecedor f = db.tb_fornecedor.FirstOrDefault(x => x.id_fornecedor == fornecedor.id_fornecedor);

            db.tb_fornecedor.Remove(f);

            db.SaveChanges();

            //tb_produto rem = db.tb_produto.FirstOrDefault(x => x.id_produto == produto.id_produto);

            //db.tb_produto.Remove(rem);

            //db.SaveChanges();
        }
		
        public void Alterar(Entity.tb_fornecedor fornecedor)
        {
            Entity.tb_fornecedor f = db.tb_fornecedor.FirstOrDefault(y => y.id_fornecedor == fornecedor.id_fornecedor);

            f.nm_fornecedor = fornecedor.nm_fornecedor;
            f.nm_responsavel = fornecedor.nm_responsavel;
            f.nr_celular = fornecedor.nr_celular;
            f.nr_cnpj = fornecedor.nr_cnpj;
            f.nr_tel = fornecedor.nr_tel;
            f.tp_fornecimento = fornecedor.tp_fornecimento;

            db.SaveChanges();

            //Entity.tb_cargo cargos =
            //db.tb_cargo.FirstOrDefault(y => y.id_cargo == cargo.id_cargo);
            //cargos.id_cargo = cargo.id_cargo;
            //cargos.tp_cargo = cargo.tp_cargo;
            //cargos.ds_descricao_cargo = cargo.ds_descricao_cargo;

            //db.SaveChanges();
        }

        public bool ExisteCNPJ(DataBase.Entity.tb_fornecedor fornecedor)
        {
            bool existe = db.tb_fornecedor.Any(x => x.nr_cnpj == fornecedor.nr_cnpj);

            return existe;
        }

    }
}
