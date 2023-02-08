using StaycationDemo.Models.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace StaycationDemo.Models.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers =>
            new List<User>
            {
                new User {FirstName = "Stephen", LastName = "Odiba", Email = "steve@gmail.com", Password = "Stephen@2"},
                new User {FirstName = "Fred", LastName = "Odiba", Email = "fred@gmail.com", Password = "Fred@2"},
                new User {FirstName = "Mark", LastName = "Odiba", Email = "Mark@gmail.com", Password = "Mark@2"},
                new User {FirstName = "Chris", LastName = "John", Email = "chris@gmail.com", Password = "Chris@2"}
            };

        public User GetUserByEmailAndPassword(string email, string password)
        {
            User user = null;
            foreach (var c in AllUsers)
            {
                if (c.Email == email || c.Password == password)
                    user = c;
            }
            return user;
        }

        public bool SaveCustomer(User customer)
        {
            bool isSaved = false;
            foreach (var c in AllUsers)
            {
                if (customer.Email == c.Email) return isSaved;

            }
            AllUsers.Append(customer);
            isSaved = true;
            return isSaved;
        }
    }
}
