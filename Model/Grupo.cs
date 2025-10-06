using System.ComponentModel.DataAnnotations;

namespace ServiTech.Model
{
    public class Grupo
    {
        [Key]

        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; } = true;

        public ICollection<SubGrupo> SubGrupos { get; set; } 
        public ICollection<Produto> Produtos { get; set; } 
    }
}