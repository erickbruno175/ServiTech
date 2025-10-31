using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Util
{
    public  class GerarCodigoBarra
    {

        public static string GerarEAN13()
        {
            Random random = new Random();
            string baseCodigo = string.Concat(Enumerable.Range(0, 12).Select(_ => random.Next(0, 10).ToString()));
            int digitoVerificador = CalcularDigitoVerificador(baseCodigo);
            return baseCodigo + digitoVerificador;
        }

        private static  int CalcularDigitoVerificador(string codigo)
        {
            int soma = 0;
            for (int i = 0; i < codigo.Length; i++)
            {
                int numero = int.Parse(codigo[i].ToString());
                soma += (i % 2 == 0) ? numero : numero * 3;
            }

            int resto = soma % 10;
            return resto == 0 ? 0 : 10 - resto;
        }
    }
}
