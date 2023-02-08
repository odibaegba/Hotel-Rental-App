using StaycationDemo.Models;
using StaycationDemo.ViewModels;

namespace StaycationDemo.Services
{
    public interface IUserServices
    {
        User Login(LoginViewModel model);
        bool Register(RegisterViewModel model);
    }
}