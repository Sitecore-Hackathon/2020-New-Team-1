using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Data;
using Sitecore.Mvc.Presentation;
using SitecoreMarketplace.Foundation.Search.Interfaces;
using SitecoreMarketplace.Foundation.Search.Services;
using SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Models;

namespace SitecoreMarketplace.Project.Web.Areas.SitecoreMarketplace.Controllers
{
    public class FeaturedModulesControllers : Controller
    {
        private ISearchService _searchService;

        public FeaturedModulesControllers()
        {
            _searchService = new SearchService();   
        }

        public ActionResult FeaturedModules()   
        {
            var category = Request.QueryString["category"];
            var item = RenderingContext.Current.Rendering.Item;

            var categoryItem = Context.Database.GetItem(new ID(item.Fields["Category"].Value));

            var categoryName = categoryItem.Fields["Name"].Value;
            var categoryDescription = categoryItem.Fields["Description"].Value;

            var searchResults = _searchService.GetModulesByCategory(categoryName);

            var modulesBlock = new ModulesBlockViewModel
            {
                Header = categoryName,
                Description = categoryDescription,
                SearchResults = searchResults
            };

            return View("FeaturedModules", modulesBlock);
        }
    }
}