using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMarketplace.Foundation.Search.Models;

namespace SitecoreMarketplace.Foundation.Search.Interfaces
{
    interface IModuleRepository
    {
        List<ModuleSearchResult> GetAllModules();   
        List<ModuleSearchResult> GetModulesByCategory(string category);   
        List<ModuleSearchResult> GetModulesByTextQuery(string textQuery);           
        List<ModuleSearchResult> GetModulesByVersions(List<string> versionsFromFilter);       
    }
}
