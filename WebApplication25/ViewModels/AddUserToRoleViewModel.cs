using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication25.ViewModels
{
	public class AddUserToRoleViewModel
	{
		[Required]
		public string RoleId { get; set; }

		[Required]
		public string UserName { get; set; }
	}

}
