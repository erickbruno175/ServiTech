using ServiTech.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;

namespace ServiTech.Model.ModelTransportadora
{
    public class Transportadora
    {

        [Key]
        public int Id { get; set; }
        public string TipoPessoa { get; set; } // Fisica ou Juridica
        public string CnpjCpf { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string TipoInscricao { get; set; }
        public string Segmento { get; set; }
        public string TelefoneFixo { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string RNTRC { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string TipoModalidadeFrete { get; set; }
        public string PlacaVeiculo { get; set; }
        public string TipoVeiculo { get; set; }

        public string TipoTransportadora { get; set; }
        public string UfVeiculo { get; set; }
        public string Motorista { get; set; }
        public string CpfMotorista { get; set; }
        public string Observacao { get; set; }

        public DateTime DataCadastro { get; set; } 

        public DateTime DataUltimaAtualizacao { get; set; }
    }
}
