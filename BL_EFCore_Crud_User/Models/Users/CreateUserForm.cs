using System.ComponentModel.DataAnnotations;

namespace BL_EFCore_Crud_User.Models.Users
{
	public class CreateUserForm
	{
		[Required]
		[StringLength(50, ErrorMessage = "Le prénom est obbligatoire")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Le nom est obbligatoire")]
		public string LastName { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "L'adresse mail n'est pas valide")]
		public string Email { get; set; }

		[Required]
		[StringLength(20, MinimumLength = 8, ErrorMessage = "Le mot de passe doit avoir 8 caractères minimum et 20 max")]
		[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
		public string Pwd { get; set; }

		[Compare("Pwd", ErrorMessage = "Les mots de passe ne correspondent pas")]
		public string PwdConfirmation { get; set; }
	}
}
