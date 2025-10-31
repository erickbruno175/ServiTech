using Microsoft.EntityFrameworkCore;
using ServiTech.Enum;
using ServiTech.Enumeradores;
using ServiTech.Model.ModelGrupo;
using ServiTech.Model.ModelTributacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiTech.Model
{
    [Index(nameof(CodigoBarraEAN) , IsUnique = true)]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        // === DADOS BÁSICOS ===
        public int CodigoInterno { get; set; }


        public string CodigoBarraEAN { get; set; }
        public string CodigoBarraAlternativo { get; set; } // "Cód de barras alternativo"


        public string CodigoBalanca { get; set; }

        public string Nome { get; set; } // Nome/Descrição

        public string UnidadeMedidaEntrada { get; set; }

        public string UnidadeMedidaSaida { get; set; }


        [ForeignKey(nameof(Marca))]
        public int? MarcaFabricanteId { get; set; }
        public Marca Marca { get; set; }

        [ForeignKey(nameof(Grupo))]
        public int? GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        [ForeignKey(nameof(SubGrupo))]
        public int? SubGrupoId { get; set; }
        public SubGrupo SubGrupo { get; set; }

        public string TipoProduto { get; set; } // Perecível / Não Perecível

        public bool Ativo { get; set; } = true;
        public bool PermitidoDesconto { get; set; } = true;

        public bool ProdutoBalanca { get; set; } = false;


        public string Cor { get; set; }
        public string Tamanho { get; set; }

        // === RELACIONAMENTOS ===
        [ForeignKey(nameof(Fornecedor))]
        public int? FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        // === FINANCEIRO ===
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoCusto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoVenda { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Margem { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Lucro { get; set; }




        public DateTime? UltimaCompra { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public DateTime? DataValidade { get; set; }


        public string Observacao { get; set; }

        // === FISCAL ===
        [ForeignKey(nameof(OrigemMercadoria))]
        public int? OrigemMercadoriaId { get; set; }
        public OrigemMercadoria OrigemMercadoria { get; set; }

        [ForeignKey(nameof(Ncm))]
        public int? NcmId { get; set; }
        public NCM Ncm { get; set; }

        [ForeignKey(nameof(CFOP))]
        public int? CfopId { get; set; }
        public CFOP CFOP { get; set; }

        [ForeignKey(nameof(CSTCSOSN))]
        public int? CstId { get; set; }
        public CSTCSOSN CSTCSOSN { get; set; }

        // Alíquotas dos impostos (percentuais)
        [Column(TypeName = "decimal(18,2)")]
        public decimal PIS { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal COFINS { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ICMS { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal IPI { get; set; }

        // === ESTOQUE ===
        [Column(TypeName = "decimal(18,2)")]
        public decimal PontoReposicao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal QuantidadeEstoque { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal QuantidadeMaxima { get; set; }

        // === IMAGEM ===,

        public byte[] FotoProduto { get; set; }
    }
}
