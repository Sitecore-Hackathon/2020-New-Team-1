using System;
using System.Collections.Generic;
using SitecoreMarketplace.Foundation.Search.Interfaces;
using SitecoreMarketplace.Foundation.Search.Models;
using SitecoreMarketplace.Foundation.Search.Repositories;

namespace SitecoreMarketplace.Foundation.Search.Services
{
    public class SearchService : ISearchService
    {
        private IModuleRepository _moduleRepository;
        
        public SearchService()
        {
            _moduleRepository =  new MockModuleRepository();
        }

        public List<ModuleSearchResult> GetModules()
        {
            return _moduleRepository.GetAllModules();
        }

        public List<ModuleSearchResult> GetModulesByCategory(string category)
        {
            return _moduleRepository.GetModulesByCategory(category);
        }

        public List<ModuleSearchResult> GetModulesByTextQuery(string textQuery)
        {
            return _moduleRepository.GetModulesByTextQuery(textQuery);
        }

        public List<ModuleSearchResult> GetModulesByVersions(List<string> versionsFromFilter)
        {
            return _moduleRepository.GetModulesByVersions(versionsFromFilter);
        }
    }
}
