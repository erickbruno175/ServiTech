using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model
{
    public class Estoque
    {
        public int Id { get; set; }


        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeMaxima { get; set; }
        public int QuantidadeMinima { get; set; }

        public DateTime UltimaSaida { get; set; }
        public DateTime UltimaEntrada { get; set; }

    }
}
