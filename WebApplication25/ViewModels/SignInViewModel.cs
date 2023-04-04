using System.ComponentModel.DataAnnotations;

namespace WebApplication25.ViewModels
{
	public class SignInViewModel
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Passowrd { get; set; }

		public bool RememberMe { get; set; }
	}
}
