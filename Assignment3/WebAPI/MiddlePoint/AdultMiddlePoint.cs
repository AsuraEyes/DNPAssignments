using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.MiddlePoint
{
    public class AdultMiddlePoint : IAdultMiddlePoint
    {
        private IList<Adult> adults;
        private IAdultService adultService;
        private List<string> filterList;

        public AdultMiddlePoint(IAdultService adultService)
        {
            this.adultService = adultService;
            adults = adultService.GetAdultsAsync().Result;
        }
        public async Task<List<Adult>> SearchFilterAsync(string searchByName)
        {
            var adultsToShow = adults.Where(t =>
                searchByName != null && (t.FirstName.Contains(searchByName, StringComparison.OrdinalIgnoreCase) ||
                                              t.LastName.Contains(searchByName, StringComparison.OrdinalIgnoreCase))).ToList();
            var ordered = adultsToShow.OrderBy(t => t.Id).ToList();
            return ordered;
        }

        public async Task<IList<string>> GetFilterCategories()
        {
            return filterList;
        }
    }
}