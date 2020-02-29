using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMarketplace.Foundation.Rating.Models
{
    class Rating
    {
        public double Average { get; set; }
        public int Total { get; set; }
        public Dictionary<int, int> Chart { get; set; }
        public string ModuleId { get; set; }
    }
}
