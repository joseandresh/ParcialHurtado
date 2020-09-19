using System.ComponentModel.DataAnnotations;

namespace ParcialHurtado.Models
{
	public class Country
	{
		[Required]
		[StringLength = 3]
		public string alpha3Code { get; set; }

	}
}