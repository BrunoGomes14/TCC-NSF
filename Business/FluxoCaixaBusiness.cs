using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Business
{
    class FluxoCaixaBusiness
    {
        public List<DataBase.Entity.fluxo_otica> Fluxo(DataBase.Entity.fluxo_otica vw, DateTime inicio, DateTime fim)
        {
            DataBase.FluxoCaixa db = new DataBase.FluxoCaixa();
            List<DataBase.Entity.fluxo_otica> fluxo = db.FluxoTotal();


            if (vw.tp_operacao == "--Selecione--")
            {
                throw new ArgumentException("Por favor, escolha o tipo de operação para proseguir");
            }
            if(vw.tp_operacao == "Ambos")
            {
                fluxo = db.FluxoMensal(vw);
            }
            else
            {
                fluxo = db.FluxoMensalOperacao(vw, inicio, fim).ToList();
            }
            
            
           
           

            return fluxo;
        }
    }
}
