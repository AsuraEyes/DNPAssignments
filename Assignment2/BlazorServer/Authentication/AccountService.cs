using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorServer.Models;

namespace BlazorServer.Authentication
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient Client;
        private readonly string url = "https://localhost:5003";

        public AccountService()
        {
            Client = new HttpClient();
        }

        public async Task<Account> ValidateUserAsync(string username, string password)
        {
            try
            {
                var stringAsync =
                    await Client.GetStringAsync(url + $"/authentication?username={username}&password={password}");
                var account = JsonSerializer.Deserialize<Account>(stringAsync, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
                return account;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}