using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class UserRepository
    {
        private static readonly List<User> _users = null;

        static UserRepository()
        {
            _users = new List<User>()
            {
                new User
                {
                    Id = 1,
                    Email = "0hasanablak@gmail.com",
                    Password = "password"
                }
            };
        }


        public static List<User> Users { get { return _users; } }

        public static void AddUser(User user) { 
        
            _users.Add(user);
        }

        public static User GetById(int id) { 

            return _users.Where(user => user.Id == id).FirstOrDefault();
        }

        public static User Attempt(string email, string password)
        {
            return _users
                .Where(user => user.Email == email)
                .Where(user => user.Password == password)
                .FirstOrDefault();
        }


    }
}
