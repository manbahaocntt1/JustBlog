using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BasedProjectDbContext _context;

        public CommentRepository(BasedProjectDbContext context)
        {
            _context = context;
        }
        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void AddComment(Guid postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            var comment = new Comment
            {
                PostId = postId,
                Name = commentName,
                Email = commentEmail,
                CommentHeader = commentTitle,
                CommentText = commentBody,
                CommentTime = DateTime.UtcNow
            };
            AddComment(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(Guid commentId)
        {
            var comment = Find(commentId);
            if (comment != null) DeleteComment(comment);
        }

        public Comment Find(Guid commentId) => _context.Comments.Find(commentId);

        

        public IList<Comment> GetAllComments() => _context.Comments.ToList();

        public IList<Comment> GetCommentsForPost(Guid postId) =>
         _context.Comments.Where(c => c.PostId == postId).ToList();

        public IList<Comment> GetCommentsForPost(Post post) =>
            GetCommentsForPost(post.Id);

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }
    }
}
