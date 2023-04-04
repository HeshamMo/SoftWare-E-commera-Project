using System.ComponentModel.DataAnnotations;

namespace WebApplication25.Helpers
{
	public class RestrictAge:ValidationAttribute
	{
		private readonly int _minAge;
		public RestrictAge(int minAge)
		{
			_minAge = minAge;
		}

		public override bool IsValid(object value)
		{
			if ((int)value < _minAge)
			{
				return false;
			}
			return true;
		}
	}
}
