using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model.ModelLocalidade
{
    public class Bairro
    {


        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
