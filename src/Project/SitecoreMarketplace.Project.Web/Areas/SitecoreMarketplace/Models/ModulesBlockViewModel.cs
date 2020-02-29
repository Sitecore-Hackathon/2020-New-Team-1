using System.Collections.Generic;
using SitecoreMarketplace.Foundation.Search.Models;

namespace SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Models
{
    public class ModulesBlockViewModel
    {
        public string Header { get; set; }
        public string Description { get; set; }

        public List<ModuleSearchResult> SearchResults { get; set; } 
    }
}