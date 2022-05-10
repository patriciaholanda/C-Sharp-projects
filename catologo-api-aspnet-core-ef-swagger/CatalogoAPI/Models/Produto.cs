using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogoAPI.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(100)]
        public string? Descricao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        [StringLength(300)]
        public string? ImagemUrl { get; set; }

        public int Estoque { get; set; }

        public DateTime DataCadastro { get; set; }

        public int CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}