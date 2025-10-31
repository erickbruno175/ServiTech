using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model.ModelGrupo
{
    public class Grupo
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public ICollection<SubGrupo> subgrupo { get; set; } = new List<SubGrupo>();

        public ICollection<Produto> produto { get; set; } = new HashSet<Produto>();
    }
}
