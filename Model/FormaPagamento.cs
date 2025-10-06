using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model
{
    public class FormaPagamento
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public bool Ativo { get; set; }

        public bool PermiteParcelamento { get; set; }

        public string Banco { get; set; } = string.Empty;

        public decimal Taxa { get; set; } = 0;



    }
}
