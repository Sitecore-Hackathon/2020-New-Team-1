using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMarketplace.Foundation.Search.Interfaces;
using SitecoreMarketplace.Foundation.Search.Models;

namespace SitecoreMarketplace.Foundation.Search.Repositories
{
    public class MockModuleRepository : IModuleRepository
    {
        public List<ModuleSearchResult> GetAllModules()
        {
            return GetAllSearchItems(); 
        }

        public List<ModuleSearchResult> GetModulesByCategory(string category)
        {
            return GetAllSearchItems().Where(item => item.Category.Equals(category, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<ModuleSearchResult> GetModulesByTextQuery(string textQuery)
        {
            return GetAllSearchItems().Where(item => item.Title.Contains(textQuery) || item.ShortDescription.Contains(textQuery)).ToList();
        }

        public List<ModuleSearchResult> GetModulesByVersions(List<string> versionsFromFilter)
        {
            return GetAllSearchItems().Where(item => versionsFromFilter.All(versionFromFilter => item.SitecoreVersions.Any(itemVersion => versionFromFilter == itemVersion))).ToList();
        }

        private List<ModuleSearchResult> GetAllSearchItems()
        {
            var moduleList = new List<ModuleSearchResult>
            {
                new ModuleSearchResult
                {
                    Title = "SITECORE INSTANCE MANAGER (SIM 1.5)",
                    ShortDescription = "SIM 1.5 is an open source tool for managing the local park of Sitecore instances. You can install, locate, maintain, reinstal or delete Sitecore products. It has API and plugin engine so you can extend it for any your need.",
                    Developer = "Oleksandr Povar",
                    Id = "59174e2c-6e3a-4e6e-807d-1daee8acac00",
                    ImageUrl = "https://marketplace.sitecore.net/img/modules/large/icon_reporting.png",
                    Rating = 5.0,
                    Category = "Reporting",
                    SitecoreVersions = new List<string>
                    {
                        "SXP 9.0",
                        "SXP 8.2"
                    }
                },
                new ModuleSearchResult()
                {
                    Title = "Old Reporting Product",
                    ShortDescription = "It is an open source tool for managing the local park of Sitecore instances. All cats will be happy",
                    Developer = "Smart Guy",
                    Id = "e6937f22-7f43-4a75-b18f-8203d499730d",
                    ImageUrl = "https://www.flaticon.com/premium-icon/icons/svg/2604/2604709.svg",
                    Rating = 4.0,
                    Category = "Reporting",
                    SitecoreVersions = new List<string>
                    {
                        "SXP 8.1",
                        "SXP 8.2"
                    }
                },
                new ModuleSearchResult()
                {
                    Title = "Old PowerShell Module",
                    ShortDescription = "It is an open source tool Powershell module for pleasure. All ducks will be happy",
                    Developer = "Good Developer",
                    Id = "17607d26-dea3-497f-a70a-144ad96b61e3",
                    ImageUrl = "https://www.flaticon.com/premium-icon/icons/svg/2589/2589125.svg",
                    Rating = 4.5,
                    Category = "PowerShell",
                    SitecoreVersions = new List<string>
                    {
                        "SXP 8.0",
                        "SXP 8.1",
                        "SXP 8.2"
                    }
                },
                new ModuleSearchResult()
                {
                    Title = "Coll PowerShell Module",
                    ShortDescription = "It is an open source tool Powershell module for pleasure. All dogs will be happy",
                    Developer = "Curious Developer",
                    Id = "17607d26-dea3-497f-a70a-144ad96b61e3",
                    ImageUrl = "https://www.flaticon.com/premium-icon/icons/svg/2589/2589125.svg",
                    Rating = 4.5,
                    Category = "PowerShell",
                    SitecoreVersions = new List<string>
                    {
                        "SXP 9.0",
                        "SXP 8.2"
                    }
                }
            };

            return moduleList;
        }
    }
}
