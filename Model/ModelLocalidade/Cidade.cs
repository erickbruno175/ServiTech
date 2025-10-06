using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model.ModelLocalidade
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        public ICollection<Bairro> Bairros { get; set; }

    }
}
