using StaycationDemo.Helpers;
using StaycationDemo.Models;
using StaycationDemo.Models.Abstractions;
using StaycationDemo.ViewModels;

namespace StaycationDemo.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IUtilities _utilities;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(LoginViewModel model)
        {

            User user = _userRepository.GetUserByEmailAndPassword(model.Email, model.Password);
            return user;
        }

        public bool Register(RegisterViewModel model)
        {
            string password = _utilities.HashPassword(model.Password);

            User user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = password,
            };

            bool registered = _userRepository.SaveCustomer(user);

            return registered;
        }
    }
}
