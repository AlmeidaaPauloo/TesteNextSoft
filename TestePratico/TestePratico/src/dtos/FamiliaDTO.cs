using System.ComponentModel.DataAnnotations;

namespace TestePratico.src.dtos
{
    public class NovaFamiliaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }
        
        public int Id_Condominio { get; set; }

        [Required]
        public int Apto { get; set; }

        [Required]
        public decimal AreaApto { get; set; }

        [Required]
        public  decimal IPTUProporcional{ get; set; }

        [Required]
        public decimal FracaoIdeal { get; set; }
        

        public NovaFamiliaDTO(int id,string nome, int id_condominio, int apto)
        {
            Id = id;
            Nome = nome;
            Id_Condominio = id_condominio;
            Apto = apto;
        }
    }
    public class AtualizarFamiliaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Apto { get; set; }

        [Required]
        public decimal AreaApto { get; set; }

        [Required]
        public decimal IPTUProporcional { get; set; }

        [Required]
        public decimal FracaoIdeal { get; set; }
        public AtualizarFamiliaDTO(int id, string nome, int apto, decimal areaApto, decimal iptuProporcional, decimal fracaoIdeal)
        {
            Id = id;
            Nome = nome;
            Apto = apto;
            AreaApto = areaApto;
            IPTUProporcional = iptuProporcional;
            FracaoIdeal = fracaoIdeal;

        }
    }
}
