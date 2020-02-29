using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMarketplace.Foundation.Comments.Models;

namespace SitecoreMarketplace.Foundation.Comments.Services
{
    interface ICommentService
    {
        IEnumerable<Comment> GetComments();
        void NewComment(Comment comment);
    }
}
