using Microsoft.AspNetCore.Mvc;

namespace IntroMvcAspNet.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
