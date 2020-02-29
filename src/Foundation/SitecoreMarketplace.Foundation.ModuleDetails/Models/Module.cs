using System.Collections.Generic;

namespace SitecoreMarketplace.Foundation.ModuleDetails.Models
{
    class Module
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string URL { get; set; }
        public IEnumerable<string> ScreenShots { get; set; }
        public IEnumerable<string> Versions { get; set; }

    }
}
