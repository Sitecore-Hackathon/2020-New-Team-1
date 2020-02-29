using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMarketplace.Foundation.Search.Models
{
    public class ModuleSearchResult
    {
        public string Id { get; set; }  
        public string ImageUrl { get; set; }
        public string Title { get; set; }   
        public string ShortDescription { get; set; }        
        public List<string> SitecoreVersions { get; set; }        
        public string Category { get; set; }    
        public double Rating { get; set; }    
        public string Developer { get; set; }       
    }
}
