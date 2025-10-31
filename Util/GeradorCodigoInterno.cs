using ServiTech.DbConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Util
{
    public  class GeradorCodigoInterno
    {
        private static int novoCodigo;
        public static int GerarCodigoInterno(DbConectionPdv conectionPdv)
        {
            if (conectionPdv.Produto.Any())
            {
                novoCodigo = conectionPdv.Produto.Max(p => p.CodigoInterno) + 1;
            }
            else
            {
                novoCodigo = 1000;
            }
            return novoCodigo;
        }
    }
}
