using BasedProject.Models.BaseEntities;

namespace BasedProject.WebMVC.Models
{
    public class HomeViewModel
    {
        public IList<Post> LatestPosts { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Tag> PopularTags { get; set; }

    }
}
