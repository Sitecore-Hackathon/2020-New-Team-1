using System.Web.Mvc;
using SitecoreMarketplace.Foundation.Search.Interfaces;
using SitecoreMarketplace.Foundation.Search.Services;
using SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Models;


namespace SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Controllers
{
    public class SearchResultsController : Controller
    {
        private ISearchService _searchService;

        public SearchResultsController()
        {
            _searchService = new SearchService();
        }

        public ActionResult SearchResults() 
        {
            var searchQuery = Request.QueryString["searchText"];
            var searchResults = string.IsNullOrWhiteSpace(searchQuery)
                ? _searchService.GetModules()
                    : _searchService.GetModulesByTextQuery(searchQuery);
            
            var modulesBlock = new ModulesBlockViewModel
            {
                SearchResults = searchResults
            };
                
            return View("SearchResults", modulesBlock);
        }
    }
}