using ServiTech.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiTech.Model
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        public string Nomefantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string CnpjCpf { get; set; }

        public string TipoPessoa { get; set; }

        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string EmailContato { get; set; }
        public string CargoContato { get; set; }
        public string RamoAtividade { get; set; }
        public string TipoInscricao { get; set; }
        public string TipoFornecedor { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Pais { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string CodigoBanco { get; set; }
        public string ChavePix { get; set; }
        public string Observacoes { get; set; }
        public string TipoConta { get; set; }
        public string Whatsapp { get; set; }
        public string WhatsappContato { get; set; }

        // 🔹 Campos que podem ser nulos no banco (evita SqlNullValueException)
        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

       
    }
}
