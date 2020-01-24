using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class JornadaBusiness
    {
        public void InserirJornada(DataBase.Entity.tb_jornada jornada)
        {
            double conta = jornada.hr_saida.Value.TotalHours - jornada.hr_entrada.Value.TotalHours;

            if(conta > 8)
            {
                throw new ArgumentException("A jornada de trabalho não pode ser maior a 8 Horas");
            }

            DataBase.JornadaDatabase db = new DataBase.JornadaDatabase();
            db.InserirJornada(jornada);

        }
    }
}
