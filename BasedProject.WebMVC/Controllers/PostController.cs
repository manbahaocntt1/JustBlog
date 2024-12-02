using BasedProject.DataAccess.Repositories;
using BasedProject.Models.BaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace BasedProject.WebMVC.Controllers
{
    public class PostController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPostRepository _postRepository;

        // Constructor for dependency injection
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // Action to display all post
        public IActionResult Index(string tag)
        {
            if (!string.IsNullOrEmpty(tag))
            {
                // Filter posts by tag
                var filteredPosts = _postRepository.GetPostsByTag(tag);
                return View(filteredPosts);
            }

            // Default behavior: display all posts
            var posts = _postRepository.GetAllPosts();
            return View(posts);
        }

        //Posts management
        public IActionResult PostManagement()
        {
            // Default behavior: display all posts
            var posts = _postRepository.GetAllPosts();
            return View(posts);
        }


        // Action to display post details
        public ActionResult Details(Guid id)
        {
            var post = _postRepository.FindPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
        // Action to display post details test for admin functions
        public ActionResult DetailsPost(Guid id)
        {
            var post = _postRepository.FindPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }



        // Action to create a new post
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.PostedOn = DateTime.Now;
                _postRepository.AddPost(post);
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // Action to edit a post
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var post = _postRepository.FindPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                _postRepository.UpdatePost(post);
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // Action to delete a post
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var post = _postRepository.FindPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(Guid id)
        {
            _postRepository.DeletePost(id);
            return RedirectToAction("Index");
        }


        //get latest posts
        public ActionResult GetLatestPosts()
        {
           var latestPosts= _postRepository.GetLatestPosts(5);
            return View("Index",latestPosts);
        }

        //get posts by category
        public ActionResult PostsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return RedirectToAction("Index");
            }

            // Fetch posts based on the category
            var posts = _postRepository.GetPostsByCategory(category);
            return View("Index", posts);
        }
    }
}
