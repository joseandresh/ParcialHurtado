using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestCountries.Models
{
	public class Country
	{
		[Key]
		[Required(ErrorMessage = "You must enter the field {0}")]
		[StringLength(3, ErrorMessage = "The field {0} must have 3 characters")]
		public string alpha3Code { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string region { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string name { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public int area { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public List<CallingCode> callingCodes { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public List<Language> languages { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		[RegularExpression(@"^http(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$", ErrorMessage = "The field {0} must have be URL")]
		public string flag { get; set; }
	}

	public class CallingCode
	{
		[Key]
		[Required(ErrorMessage = "You must enter the field {0}")]
		public int number { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string capital { get; set; }
	}

	public class Language
	{
		[Key]
		[Required(ErrorMessage = "You must enter the field {0}")]
		public string iso639_1 { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string iso639_2 { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string name { get; set; }

		[Required(ErrorMessage = "You must enter the field {0}")]
		public string nativeName { get; set; }
	}

}