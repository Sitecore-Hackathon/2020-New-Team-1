using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMarketplace.Foundation.Comments.Models
{
    class Comment
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public UserProfile UserProfile { get; set; }
        public DateTime Date { get; set; }
        public int Karma { get; set; }
    }
}
