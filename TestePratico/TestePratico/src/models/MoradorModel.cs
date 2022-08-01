using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico.src.Models
{
	[Table("tb_morador")]
	public class MoradorModel
	{
        [Key]
		public int Id { get; set; }

        [ForeignKey("Fk_familia")]
		public int IdFamilia { get; set; }

		[Required]
		public string Nome { get; set; }

		[Required]
		public int Idade { get; set; }

		[Required]
		public int Apto { get; set; }

	}
}



