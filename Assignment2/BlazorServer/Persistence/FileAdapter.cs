using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorServer.Models;

namespace BlazorServer.Persistence
{
    public class FileAdapter : IFileAdapter, IStatisticsModel
    {
        // private FileContext Context;
        private readonly HttpClient Client;
        private readonly string uri = "https://localhost:5003";

        public FileAdapter()
        {
            // Context = new FileContext();
            Client = new HttpClient();
        }


        public async Task<List<Adult>> GetAdultsAsync()
        {
            var stringAsync = Client.GetStringAsync(uri + "/adults");
            var message = await stringAsync;
            var adults = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return adults;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            var adultJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultJson, Encoding.UTF8, "application/json");
            await Client.PostAsync(uri + "/adults", content);
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            var stringAsync = Client.GetStringAsync(uri + $"/adults/{id}");
            var message = await stringAsync;
            var adult = JsonSerializer.Deserialize<Adult>(message, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return adult;
        }

        public async Task RemoveAdultAsync(Adult adult)
        {
            await Client.DeleteAsync(uri + $"/adults/{adult.Id}");
        }

        public async Task UpdateAsync(Adult adult)
        {
            var adultJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultJson, Encoding.UTF8, "application/json");
            await Client.PatchAsync(uri + "/adults", content);
        }

        public async Task<int> GetAdultAgeGroupAsync(int minimum, int maximum)
        {
            var message = await Client.GetStringAsync(uri + $"/statistics?minimum={minimum}&maximum={maximum}");
            var count = int.Parse(message);
            return count;
        }

        public async Task<double> GetEyeColorPercentage(string color)
        {
            var message = await Client.GetStringAsync(uri + $"/statistics/{color}");
            var num = double.Parse(message);
            return num;
        }
    }
}