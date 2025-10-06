using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Model
{
    public class Produto
    {

        [Key]
        public int Id { get; set; }
        public string CodigoInterno { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }

        [ForeignKey("FornecedorId")]
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public string UnidadeMedida { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal MargemLucro { get; set; }

        [ForeignKey("GrupoId")]
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        [ForeignKey("SubGrupoId")]
        public int SubGrupoId { get; set; }
        public SubGrupo SubGrupo { get; set; }

        public bool Ativo { get; set; } = true;
        public string Tamanho { get; set; }
        public string Cor { get; set; }

        public string OrigemMercadoria { get; set; }

        public int NCM { get; set; }
        public int CEST { get; set; }
        public string CFOP { get; set; }
        public string CSOSN { get; set; }

        public decimal ICMS { get; set; }
        public decimal IPI { get; set; }
        public decimal PIS { get; set; }
        public decimal COFINS { get; set; }

        public decimal MVA { get; set; }
        public string Observacao { get; set; }
        public bool Desconto { get; set; } = false;
        public DateTime DataCadastro { get; set; }

        public string FotoProduto { get; set; }










    }
}
