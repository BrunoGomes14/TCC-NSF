using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class VendaBusiness
    {
        DataBase.VendaDatabase db = new DataBase.VendaDatabase();

        public List<DataBase.Entity.tb_produto> ConsultarParaVenda(DataBase.Entity.tb_produto produto)
        {
            DataBase.ProdutoDatabase p = new DataBase.ProdutoDatabase();

            bool existe = p.ExisteProduto(produto);

            if(!existe)
            {
                throw new ArgumentException("Produto Não cadastrado no sistema.");
            }

           List< DataBase.Entity.tb_produto> pro = p.ConsultaParaVenda(produto);

            return pro;
        }
        public DataBase.Entity.tb_produto ConsultaCodBarras(DataBase.Entity.tb_produto produto)
        {
            DataBase.ProdutoDatabase pro = new DataBase.ProdutoDatabase();

            bool existe = pro.ConsultaExistecia(produto);

            if (!existe)
                throw new ArgumentException("Produto inexistente no sitema");

           DataBase.Entity.tb_produto hihi = pro.ConsultarPorCodBarras(produto);



            return hihi;
        }
        public void InserirVenda(DataBase.Entity.tb_venda_registro venda)
        {
            if(venda.vl_venda <= 0)
            {
                throw new ArgumentException("Por favor, insira os produtos para realizar vender");
            }

            db.InserirVenda(venda);
        }
        public void InserirDescVenda(DataBase.Entity.tb_desc_venda venda)
        {
            db.InserirVendaDesc(venda);
        }
            
        
        


    }
}
