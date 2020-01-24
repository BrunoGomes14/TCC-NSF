using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class ClienteBusiness
    {
        DataBase.ClienteDatabase db = new DataBase.ClienteDatabase();

        public void InserirCliente(DataBase.Entity.tb_cliente cliente)
        {
            db.InserirCliente(cliente);
        }

        public List<DataBase.Entity.tb_cliente> ListarTodos()
        {
            List<DataBase.Entity.tb_cliente> clientes = db.ListarTodos();
            return clientes;
        }

        public List<DataBase.Entity.tb_cliente> ConsultarPorNomeCliente(string nome)
        {
            List<DataBase.Entity.tb_cliente> clientes = db.ConsultarPorNomeCliente(nome);
            return clientes;
        }

        public void removercliente(DataBase.Entity.tb_cliente cliente)
        {
            db.removercliente(cliente);
        }

        public void AlterarCliente(DataBase.Entity.tb_cliente cliente)
        {
            db.AlterarCliente(cliente);
        }
    }
}
