using System.Collections.Generic;
using SitecoreMarketplace.Foundation.ModuleDetails.Models;

namespace SitecoreMarketplace.Foundation.ModuleDetails.Services
{
    class ModuleService : IModuleService
    {
        public Module GetModule(string id)
        {
            //TODO: use DAL

            return new Module
            {
                Id = "59174e2c-6e3a-4e6e-807d-1daee8acac00",
                Name = "SITECORE INSTANCE MANAGER (SIM 1.5)",
                Summary = "SIM 1.5 is an open source tool for managing the local park of Sitecore instances. You can install, locate, maintain, reinstal or delete Sitecore products. " +
                          "It has API and plugin engine so you can extend it for any your need.",
                Category = "Reporting",
                URL = "modules/59174e2c-6e3a-4e6e-807d-1daee8acac00",
                Image = "https://marketplace.sitecore.net/img/modules/large/icon_reporting.png",
                ScreenShots = new List<string>
                {
                    "https://marketplace.sitecore.net/img/modules/large/icon_reporting.png",
                    "https://marketplace.sitecore.net/img/modules/large/icon_reporting.png"
                },
                Versions = new List<string> {"SXP 9.0",  "SXP 8.2"}
            };
        }
    }
}
