using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class FaltaBusiness
    {
        DataBase.FaltaDatabase db = new DataBase.FaltaDatabase();

        public void InserirFalta(DataBase.Entity.tb_falta falta)
        {
            

            bool faltaexiste = db.ExisteFalta(falta);

            if (faltaexiste)
                throw new ArgumentException("Falta já inserida no sistema");

            db.InserirFalta(falta);
        }
        public void AlterarFalta(DataBase.Entity.tb_falta falta)
        {
            bool existe = db.ExisteFalta(falta);

            if (!existe)
                throw new ArgumentException("Esta falta não existe");

            db.AlterarFalta(falta);
        }
        public void RemoverFalta(DataBase.Entity.tb_falta falta)
        {
            db.RemoverFalta(falta.id_falta);
        }
             
    }
}
