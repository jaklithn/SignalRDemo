namespace Demo.Web.Models
{
	public class LoginModel
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}