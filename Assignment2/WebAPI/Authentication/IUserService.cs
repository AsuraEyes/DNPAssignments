using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Authentication
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
    }
}