using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Util
{
    internal class GeradorCodigoInterno
    {
        private static int UltimoCodigoInterno = 1000;

        public static int GerarCodigoInterno()
        {
            UltimoCodigoInterno++;
            int codigoInterno = UltimoCodigoInterno;
            return codigoInterno;
        }
    }
}
