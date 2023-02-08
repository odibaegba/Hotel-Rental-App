using System.Collections.Generic;

namespace StaycationDemo.Models.Abstractions
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserByEmailAndPassword(string email, string password);
        bool SaveCustomer(User user);

    }
}
