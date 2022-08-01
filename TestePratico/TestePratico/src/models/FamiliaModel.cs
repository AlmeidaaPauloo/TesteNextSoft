using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico.src.Models
{
	[Table("tb_familia")]
	public class FamiliaModel
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Nome { get; set; }

        [ForeignKey("Fk_condominio")]
		public CondominioModel Condominio { get; set; }

		public int FkCondominio { get; set; }

        [Required]
		public int Apto { get; set; }

		[Required]
		public decimal AreaApto { get; set; }

		[Required]
		public decimal IPTUProporcional { get; set; }

		[Required]
		public decimal FracaoIdeal { get; set; }

	}
}
