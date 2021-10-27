using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Authentication
{
    public class UserService : IUserService
    {
        private readonly List<User> users;

        public UserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "admin",
                    Password = "admin",
                    Role = "ADMIN"
                },
                new User
                {
                    UserName = "Timothy",
                    Password = "123456",
                    Role = "MEMBER"
                }
            }.ToList();
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            var first = users.FirstOrDefault(user => user.UserName.Equals(username));
            if (first == null) throw new Exception("User not found");
            if (!first.Password.Equals(password)) throw new Exception("Incorrect password");
            return first;
        }
    }
}