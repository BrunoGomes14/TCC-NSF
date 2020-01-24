using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.DataBase.Entity
{
    class VenderModel
    {
        public int id_produto { get; set; }

        public string nm_produto { get; set; }

        public string nm_modelo { get; set; }

        public int qtd_produto { get; set; }

        public decimal vl_produto { get; set; }
    }
}
