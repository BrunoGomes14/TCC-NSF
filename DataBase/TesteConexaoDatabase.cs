using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
	class TesteConexaoDatabase
	{
		public bool TesteConexao()
		{
			Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

			try
			{
				db.tb_cargo.Take(1).ToList();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		
	   
	}        
	
}
