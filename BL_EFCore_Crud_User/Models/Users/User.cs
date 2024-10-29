using BL_EFCore_Crud_User.Enums;
using System.Data;

namespace BL_EFCore_Crud_User.Models.Users
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Pwd { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
		public int ZipCode { get; set; }
		public string City { get; set; }
		public Role Role { get; set; }
		public int IsActif { get; set; }
		public int SaltId { get; set; }
	}
}
