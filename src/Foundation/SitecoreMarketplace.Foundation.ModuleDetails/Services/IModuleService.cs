using SitecoreMarketplace.Foundation.ModuleDetails.Models;

namespace SitecoreMarketplace.Foundation.ModuleDetails.Services
{
    interface IModuleService
    {
        Module GetModule(string id);
    }
}
