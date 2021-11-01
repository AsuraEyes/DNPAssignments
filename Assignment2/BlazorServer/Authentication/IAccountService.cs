using System.Threading.Tasks;
using BlazorServer.Models;

namespace BlazorServer.Authentication
{
    public interface IAccountService
    {
        Task<Account> ValidateUserAsync(string username, string password);
    }
}