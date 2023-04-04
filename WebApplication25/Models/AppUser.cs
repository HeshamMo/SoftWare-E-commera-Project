using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication25.Helpers;

namespace WebApplication25.Models
{
	public class AppUser:IdentityUser
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[RestrictAge(18,ErrorMessage ="Error must be at least 18")]
		public int Age { get; set; }
		[Required]
		public string Country { get; set; }
		[Column(name:"phoneNumber")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		public virtual List<Product> Products { get; set; }


	}
}
