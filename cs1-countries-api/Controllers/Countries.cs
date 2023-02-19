using cs1_countries_api.Data;
using cs1_countries_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cs1_countries_api.Controllers
{
    [ApiController]
    public class Countries: ControllerBase
    {
        public AppDbContext _context { get; set; }

        public Countries(AppDbContext context) {
            _context = context;
        }  
        
        
        //GET
        [HttpGet]
        [Route("api/[controller]/europe")]
        public async Task<IActionResult> Europe() {
            var list =  await _context.EuropeCountries.ToListAsync();
            return Ok(list);
        }

        //GET BY ID
        [HttpGet]
        [Route("api/[controller]/europe/{id}")]
        public async Task<IActionResult> EuropeId(int id) {
            var data =  await _context.EuropeCountries.FindAsync(id);
            return Ok(data);
        }

        //GET
        [HttpGet]
        [Route("api/[controller]/america")]
        public async Task<IActionResult> America() { 
            var list = await _context.AmericaCountries.ToListAsync();
            return Ok(list);
        }

        //GET BY ID
        [HttpGet]
        [Route("api/[controller]/america/{id}")]
        public async Task<IActionResult> AmericaId(int id)
        {
            var data =  await _context.AmericaCountries.FindAsync(id);
            return Ok(data);
        }

        //GET
        [HttpGet]
        [Route("api/[controller]/asia")]
        public async Task<IActionResult> Asia()
        {
            var list = await _context.AsiaCountries.ToListAsync();
            return Ok(list);
        }

        //GET BY ID
        [HttpGet]
        [Route("api/[controller]/asia/{id}")]
        public async Task<IActionResult> AsiaId(int id)
        {
            var data =  await _context.AsiaCountries.FindAsync(id);
            return Ok(data);
        }
    }
}
