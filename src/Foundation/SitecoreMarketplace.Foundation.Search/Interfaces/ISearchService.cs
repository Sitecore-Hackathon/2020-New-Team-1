using System;
using System.Collections.Generic;
using SitecoreMarketplace.Foundation.Search.Models;

namespace SitecoreMarketplace.Foundation.Search.Interfaces
{
    public interface ISearchService
    {
        List<ModuleSearchResult> GetModules();
        List<ModuleSearchResult> GetModulesByCategory(string category);
        List<ModuleSearchResult> GetModulesByTextQuery(string textQuery);
        List<ModuleSearchResult> GetModulesByVersions(List<string> versionsFromFilter);
    }
}
