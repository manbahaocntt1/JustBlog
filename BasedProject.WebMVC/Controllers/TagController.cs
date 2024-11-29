using BasedProject.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BasedProject.WebMVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagRepository _tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        //get popular tags
        [HttpGet]
        public IActionResult PopularTags()
        {
            int tagDisplayCount = 5; // You can make this configurable
            var popularTags = _tagRepository.GetPopularTags(tagDisplayCount);
            return View(popularTags);
        }
    }
}
