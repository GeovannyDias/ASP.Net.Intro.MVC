using IntroMvcAspNet.Context;
using IntroMvcAspNet.Models;
using IntroMvcAspNet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IntroMvcAspNet.Controllers
{
    public class BeerController : Controller // Controller Controlador solo tipo MVC
    {
        private readonly PubContext _context;

        public BeerController(PubContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var beers = _context.Beers.Include(b => b.Brand);
            return View(await beers.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["Brands"] = new SelectList(_context.Brands, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Valida que la información si o si sea la del formulario
        public async Task<IActionResult> Create(BeerViewModel model)
        {
            // Console.WriteLine(model);
            if (ModelState.IsValid)
            {
                var beer = new Beer()
                {
                    Name = model.Name,
                    BrandId = model.BrandId,
                };
                //_context.Beers.Add(beer);
                _context.Add(beer); // Realiza la misma acción _context.Beers.Add(beer)
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Brands"] = new SelectList(_context.Brands, "Id", "Name", model.BrandId);
            return View(model);
        }
    }
}
