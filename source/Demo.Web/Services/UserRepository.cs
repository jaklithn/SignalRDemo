using System;
using System.Linq;
using Demo.Web.Models;


namespace Demo.Web.Services
{
    public class UserRepository
    {
        private readonly UserModel[] _users =
        {
            new UserModel {Name = "Anders", Password = "123", Roles = new[] {"Admin", "User"}},
            new UserModel {Name = "Kalle", Password = "123", Roles = new[] {"User"}},
            new UserModel {Name = "Peter", Password = "123", Roles = new[] {"User"}}
        };

        public UserModel GetUser(string userName, string password)
        {
            return _users.SingleOrDefault(x => x.Name.Equals(userName, StringComparison.InvariantCultureIgnoreCase) && x.Password == password);
        }
    }
}