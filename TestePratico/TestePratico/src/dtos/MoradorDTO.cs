using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico.src.dtos
{
    public class NovoMoradorDTO
    {
        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        public NovoMoradorDTO(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    public class AtualizarMoradorDTO
    {
        [Key]
        public int Id { get; set; } 

        [Required, StringLength(50)]
        public string Nome { get; set; }

        [Required]
        public int Apto { get; set; }

        public AtualizarMoradorDTO(int id, string nome, int apto)
        {
            Id = id;
            Nome = nome;
            Apto = apto;
        }
    }
}