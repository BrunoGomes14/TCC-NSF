using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
	class ClienteDatabase

	{ Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

		public void InserirCliente(Entity.tb_cliente cliente)
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();
			db.tb_cliente.Add(cliente);
			db.SaveChanges();

		}

		public List<Entity.tb_cliente> ListarTodos()
		{
			List<Entity.tb_cliente> cliente = db.tb_cliente.ToList();
			return cliente;
		}

		public List<Entity.tb_cliente> ConsultarPorNomeCliente(string nome)
		{
			List<Entity.tb_cliente> cliente
				= db.tb_cliente.Where(x => x.nm_nome.Contains(nome)).ToList();
			return cliente;

		}
		public void removercliente(Entity.tb_cliente cliente)
		{
			Entity.tb_cliente clientes = db.tb_cliente.FirstOrDefault(x => x.nm_nome == x.nm_nome);
			db.tb_cliente.Remove(clientes);
			db.SaveChanges();
		}
		public void AlterarCliente(Entity.tb_cliente cliente)
		{
			Entity.tb_cliente clienteAlterar = db.tb_cliente.FirstOrDefault(x => x.id_cliente == cliente.id_cliente);

			clienteAlterar.id_cliente = cliente.id_cliente;
			clienteAlterar.nm_email= cliente.nm_email;
			clienteAlterar.nm_nome = cliente.nm_nome;
			clienteAlterar.nm_rua= cliente.nm_rua;
			clienteAlterar.nm_sobrenome = cliente.nm_sobrenome;
			clienteAlterar.nr_celular = cliente.nr_celular;
			clienteAlterar.nr_cep = cliente.nr_cep;
			clienteAlterar.nr_cpf = cliente.nr_cpf;
			clienteAlterar.nr_moradia = cliente.nr_moradia;
			clienteAlterar.nr_rg = cliente.nr_rg;
			clienteAlterar.nr_telefone = cliente.nr_telefone;
			
			db.SaveChanges();

		}
	}
}
