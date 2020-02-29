using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMarketplace.Foundation.Comments.Models;

namespace SitecoreMarketplace.Foundation.Comments.Services
{
    class CommentService : ICommentService
    {
        static List<Comment> _comments = new List<Comment>()
        {
            new Comment(),
            new Comment(),
            new Comment(),
            new Comment()
        };

        public IEnumerable<Comment> GetComments()
        {
            return _comments;
        }

        public void NewComment(Comment comment)
        {
            _comments.Add(comment);
        }
    }
}
