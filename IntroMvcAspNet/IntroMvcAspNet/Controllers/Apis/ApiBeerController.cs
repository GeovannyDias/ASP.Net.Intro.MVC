using IntroMvcAspNet.Context;
using IntroMvcAspNet.Models;
using IntroMvcAspNet.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// https://localhost:7049/api/ApiBeer

namespace IntroMvcAspNet.Controllers.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeerController : ControllerBase // ControllerBase Controlador solo tipo BackEnd (Regresa un JSON)
    {
        private readonly PubContext _context;
        public ApiBeerController(PubContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<List<BeerBrandViewModel>> Get()
            //=> await _context.Beers.ToListAsync();
            => await _context.Beers.Include(b=>b.Brand)
            .Select(b=>new BeerBrandViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Brand = b.Brand.Name
            })
            .ToListAsync();

    }
}
