using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCrusier.Models
{
	public class User
	{
		[Required(ErrorMessage = "Enter UserName")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Enter Password")]
		public string Password { get; set; }
		
	}
}
