using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public interface ICommentRepository
    {
        Comment Find(Guid commentId);
        void AddComment(Comment comment);
        void AddComment(Guid postId, string commentName, string commentEmail, string commentTitle, string commentBody);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
        void DeleteComment(Guid commentId);
        IList<Comment> GetAllComments();
        IList<Comment> GetCommentsForPost(Guid postId);
        IList<Comment> GetCommentsForPost(Post post);
    }
}
