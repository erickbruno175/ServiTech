using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model
{
    public class CondicaoPagamento
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroParcela { get; set; }
        public int Intervalo { get; set; }
        public decimal TaxaJuros { get; set; }
        public decimal Desconto { get; set; }
        public bool Ativo { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento? FormaPagamento { get; set; }

    }
}
