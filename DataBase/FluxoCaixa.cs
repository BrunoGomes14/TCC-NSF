using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase
{
    class FluxoCaixa
    {
        DataBase.Entity.db_a4f62c_oticaEntities db = new Entity.db_a4f62c_oticaEntities();

        public List<Entity.fluxo_otica> FluxoTotal()
        {
            
            List<DataBase.Entity.fluxo_otica> view = db.fluxo_otica.ToList();

            return view;
        }
        public List<Entity.fluxo_otica> FluxoDespesa()
        {
            List<DataBase.Entity.fluxo_otica> vw = db.fluxo_otica.Where(x => x.tp_operacao == "Despesa").ToList();

            return vw;

        }
        public List<Entity.fluxo_otica> FluxoMensalOperacao(Entity.fluxo_otica vw, DateTime inicio, DateTime fim)
        {
            List<DataBase.Entity.fluxo_otica> vwf = db.fluxo_otica.Where(x => x.tp_operacao == vw.tp_operacao
                                                      && x.DATA_PAGAMENTO >= inicio && x.DATA_PAGAMENTO <= fim
                                                                         ).ToList();

            return vwf;
        }
        public List<Entity.fluxo_otica> FluxoMensal(Entity.fluxo_otica fluxo)
        {
            List<DataBase.Entity.fluxo_otica> vw = db.fluxo_otica.Where(x => x.DATA_PAGAMENTO.Value.Month == fluxo.DATA_PAGAMENTO.Value.Month).ToList();

            return vw;
        }
    }
}
