using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public interface IPostRepository
    {
        Post FindPost(int year, int month, string urlSlug);
        Post FindPost(Guid postId);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
        void DeletePost(Guid postId);
        IList<Post> GetAllPosts();
        IList<Post> GetPublishedPosts();
        IList<Post> GetUnpublishedPosts();
        IList<Post> GetLatestPosts(int size);
        IList<Post> GetPostsByMonth(DateTime monthYear);
        int CountPostsForCategory(string category);
        IList<Post> GetPostsByCategory(string category);
        int CountPostsForTag(string tag);
        IList<Post> GetPostsByTag(string tag);

        //add the method for retrieving most viewed and highest-rated posts
        IList<Post> GetMostViewedPosts(int size);
        IList<Post> GetHighestPosts(int size);
        
    }
}
