using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class ProdutoDatabase
    {
        Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

        public void CadastrarProduto(Entity.tb_produto produto)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            db.tb_produto.Add(produto);

            db.SaveChanges();
        }
        public List<Entity.tb_produto> ConsultarTodos()
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            List<Entity.tb_produto> produto = db.tb_produto.ToList();
            return produto;
        }
        public List<DataBase.Entity.tb_produto> ConsultarPorNome(string nome)
        {
            List<Entity.tb_produto> produtos = db.tb_produto.
                                               Where(nomeP => nomeP.nm_produto.Contains(nome)).
                                               ToList();

            return produtos;

            //Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            //Entity.tb_produto produto = db.tb_produto.FirstOrDefault(a => a.nm_produto == nome);
            //return produto;        
        }
        public Entity.tb_produto ConsultarPorModelo(string modelo)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_produto produto = db.tb_produto.FirstOrDefault(a => a.nm_modelo == modelo);
            return produto;
        }
        public Entity.tb_produto ConsultarPorCor(string cor)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_produto produto = db.tb_produto.FirstOrDefault(a => a.nm_cor == cor);
            return produto;
        }
        public Entity.tb_produto ConsultarPorMarca(string marca)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_produto produto = db.tb_produto.FirstOrDefault(a => a.nm_marca == marca);
            return produto;
        }
        public Entity.tb_produto ConsultarPorTipo(string tipo)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_produto produto = db.tb_produto.FirstOrDefault(a => a.tp_produto == tipo);
            return produto;
        }
        public void Alterar(Entity.tb_produto produto)
        {
            Entity.tb_produto p = db.tb_produto.FirstOrDefault(x => x.id_produto == produto.id_produto);

            p.nm_cor = p.nm_cor;
            p.nm_marca = p.nm_marca;
            p.nm_modelo = p.nm_modelo;
            p.nm_produto = p.nm_produto;
            p.pr_preco_lote = p.pr_preco_lote;
            p.pr_preco_unidade = p.pr_preco_unidade;
            p.tp_produto = p.tp_produto;

            db.SaveChanges();

            //Entity.tb_cargo cargos =
            //db.tb_cargo.FirstOrDefault(y => y.id_cargo == cargo.id_cargo);
            //cargos.id_cargo = cargo.id_cargo;
            //cargos.tp_cargo = cargo.tp_cargo;
            //cargos.ds_descricao_cargo = cargo.ds_descricao_cargo;

            //db.SaveChanges();
        }
        public void Remover(Entity.tb_produto produto)
        {
            Entity.tb_produto p = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            db.tb_produto.Remove(p);

            db.SaveChanges();

            
        }
        public List<Entity.tb_produto> ConsultaParaVenda(DataBase.Entity.tb_produto produto)
        {
           List< Entity.tb_produto> prod = db.tb_produto.Where(x => x.cd_barras == produto.cd_barras).ToList();
            

            return prod;
      }
        public bool ExisteProduto(Entity.tb_produto prod)
        {
            bool existe = db.tb_produto.Any(x => x.cd_barras == prod.cd_barras);
            return existe;
        }
        public Entity.tb_produto ConsultarPorCodBarras(Entity.tb_produto produto)
        {
            Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
            Entity.tb_produto sla = db.tb_produto.FirstOrDefault(a => a.cd_barras == produto.cd_barras);
            return sla;
        }
        public bool ConsultaExistecia(Entity.tb_produto produto)
        {
            bool existe = db.tb_produto.Any(x => x.cd_barras == produto.cd_barras);

            return existe;
        }
    }
}
