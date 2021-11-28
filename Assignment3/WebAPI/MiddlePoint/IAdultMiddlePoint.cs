using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WebAPI.Models;

namespace WebAPI.MiddlePoint
{
    public interface IAdultMiddlePoint
    {
        Task<List<Adult>> SearchFilterAsync(string searchByName);
        Task<IList<string>> GetFilterCategories();
    }
}