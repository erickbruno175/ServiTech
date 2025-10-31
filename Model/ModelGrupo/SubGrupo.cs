using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiTech.Model.ModelGrupo
{
    public class SubGrupo
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; } = true;


        [ForeignKey("GrupoId")]
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public ICollection<Produto> Produtos { get; set; } 
    }
}