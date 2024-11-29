using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BasedProjectDbContext _context;

        public PostRepository(BasedProjectDbContext context)
        {
            _context = context;
        }
        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public int CountPostsForCategory(string category)
        {
            //var categoryId= _context.Categories.Where(c=> c.CategoryName.Equals(category)).FirstOrDefault();
            //var postsForCategory= _context.Posts.Where(p=>p.CategoryId.Equals(categoryId)).ToList();
            //return postsForCategory.Count;
            return _context.Posts.Count(p=>p.Category.CategoryName==category&&p.Published);

        }

        public int CountPostsForTag(string tag)
        {
            return _context.Posts.Count(p=>p.Tags.Any(t=>t.TagName==tag) && p.Published);
        }

        public void DeletePost(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges(); 
        }

        public void DeletePost(Guid postId)
        {
            var post = FindPost(postId);
            if(post != null)
            {
                DeletePost(post);
            }
        }

        public Post FindPost(int year, int month, string urlSlug)
        {
            return _context.Posts.FirstOrDefault(p => p.PostedOn.Year == year && p.PostedOn.Month == month && p.PostUrlSlug == urlSlug && p.Published);
        }

        public Post FindPost(Guid postId)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == postId&& p.Published);


        }

        public IList<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public IList<Post> GetMostViewedPosts(int size)
        {
            return _context.Posts.Where(p=> p.Published).OrderByDescending(p=>p.ViewCount).Take(size).ToList();
        }

        public IList<Post> GetLatestPosts(int size)
        {
            return _context.Posts.Where(p => p.Published).OrderByDescending(p=>p.PostedOn).Take(size).ToList();
        }

        public IList<Post> GetHighestPosts(int size)
        {
           return _context.Posts.Where(p => p.Published).OrderByDescending(p => p.Rate).Take(size).ToList();
        }

        public IList<Post> GetPostsByCategory(string category)
        {
            return _context.Posts.Where(p=>p.Category.CategoryName == category && p.Published).ToList();

        }

        public IList<Post> GetPostsByMonth(DateTime monthYear)
        {
            return _context.Posts.Where(p=>p.PostedOn == monthYear && p.Published).ToList();
        }

        public IList<Post> GetPostsByTag(string tag)
        {
            return _context.Posts.Where(p => p.Tags.Any(t => t.TagUrlSlug == tag)).ToList() ;
        }

        public IList<Post> GetPublishedPosts()
        {
           return _context.Posts.Where(_p => _p.Published).ToList();
        }

        public IList<Post> GetUnpublishedPosts()
        {
            return _context.Posts.Where(p => !p.Published).ToList();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }
        

    }
}
