using BasedProject.DataAccess.Repositories;
using BasedProject.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasedProject.WebMVC.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITagRepository _tagRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IPostRepository postRepository, ICategoryRepository categoryRepository,ITagRepository tagRepository, ILogger<HomeController> logger)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository; 
            _logger = logger;
        }




        public IActionResult Index()
        {
            // Fetch the latest posts and categories
            var latestPosts = _postRepository.GetLatestPosts(5); // Adjust the size as needed
            var categories = _categoryRepository.GetAllCategories();
            var popularTags=_tagRepository.GetPopularTags(3);

            // Pass them to the view using a ViewModel
            var model = new HomeViewModel
            {
                LatestPosts = latestPosts,
                Categories = categories,
                PopularTags = popularTags
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //about
        public ActionResult About()
        {
            return View();
        }


        //contact
        public ActionResult Contact()
        {
            return View();
        }


        //sample post
        public ActionResult Sample()
        {
            return View();
        }
    }
}
