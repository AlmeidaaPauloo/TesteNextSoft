using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico.src.Models
{
	[Table("tb_condominio")]
	public class CondominioModel
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		public string Nome { get; set; }       

		[Required]
		public string Bairro { get; set; }

		[Required]
		public decimal AreaTotal { get; set; }

		[Required]
		public decimal ValorIPTU { get; set; }
	}
}

