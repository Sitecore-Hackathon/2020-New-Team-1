using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMarketplace.Foundation.Rating.Models;

namespace SitecoreMarketplace.Foundation.Rating.Services
{
    class RatingService : IRatingService
    {
        static List<Models.Rating> _ratings = new List<Models.Rating>()
        {
            new Models.Rating()
                { ModuleId = "59174e2c-6e3a-4e6e-807d-1daee8acac00", Average = 4.5, Total = 1050,
                    Chart = new Dictionary<int, int>(){{1, 50}, {2, 100}, {3, 200}, {4, 300}, {5, 400}}},
            new Models.Rating(),
            new Models.Rating(),
            new Models.Rating()
        };

        public Models.Rating GetRating(string moduleId)
        {
            return _ratings
                .FirstOrDefault(_ => _.ModuleId.Equals(moduleId, StringComparison.OrdinalIgnoreCase));
        }
    }
}
