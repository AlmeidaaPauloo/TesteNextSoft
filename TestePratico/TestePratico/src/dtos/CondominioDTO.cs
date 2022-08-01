using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico.src.dtos
{
    public class NovoCondominioDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(50)]
        public string Bairro { get; set; }
        [Required]
        public decimal AreaTotal { get; set; }
        [Required]
        public decimal ValorIPTU { get; set; }


        public NovoCondominioDTO(string nome, string bairro, decimal areaTotal, decimal valorIPTU)
        {
            Nome = nome;
            Bairro = bairro;
            AreaTotal = areaTotal;
            ValorIPTU = valorIPTU;
        }
    }

    public class AtualizarCondominioDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required, StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        public decimal AreaTotal { get; set; }

        [Required]
        public decimal ValorIPTU { get; set; }

        public AtualizarCondominioDTO(int id, string nome, string bairro, decimal areaTotal, decimal valorIPTU)
        {
            Id = id;
            Nome = nome;
            Bairro = bairro;
            AreaTotal = areaTotal;
            ValorIPTU = valorIPTU;
        }
    }
}