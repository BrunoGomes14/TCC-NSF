using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class PontoBusiness
    {

        public double CalcularHorasExtras(int funcionario, DateTime mes)
        {
            DataBase.Entity.db_a4f62c_oticaEntities db = new DataBase.Entity.db_a4f62c_oticaEntities();

            var pontos =
                db.tb_ponto.Where(x => x.id_funcionario == funcionario && x.dt_entrada.Month == mes.Month).ToList();


            var horasExtras =
                           pontos.Select(x => (x.dt_saida.Value.TimeOfDay
                                         - 
                                         x.tb_funcionario.tb_jornada.First().hr_saida.Value
                                         ).TotalHours)
                           .Sum();

            return horasExtras;
        }

    }
}
