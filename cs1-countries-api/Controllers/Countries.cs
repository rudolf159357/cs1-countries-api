using cs1_countries_api.Data;
using cs1_countries_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cs1_countries_api.Controllers
{
    [ApiController]
    public class Countries
    {
        public AppDbContext _context { get; set; }

        public Countries(AppDbContext context) {
            _context = context;
        }  

        [HttpGet]
        [Route("api/[controller]/europe")]
        public async Task<ActionResult<IEnumerable<EuropeModel>>> Europe() {
            return await _context.EuropeCountries.ToListAsync();
        }

        [HttpGet]
        [Route("api/[controller]/europe/{id}")]
        public async Task<ActionResult<EuropeModel>> EuropeId(int? id) {
            return await _context.EuropeCountries.FindAsync(id);
        }

        [HttpGet]
        [Route("api/[controller]/america")]
        public async Task<ActionResult<IEnumerable<AmericaModel>>> America() { 
            return await _context.AmericaCountries.ToListAsync();
        }

        [HttpGet]
        [Route("api/[controller]/america/{id}")]
        public async Task<ActionResult<AmericaModel>> AmericaId(int? id)
        {
            return await _context.AmericaCountries.FindAsync(id);
        }

        [HttpGet]
        [Route("api/[controller]/asia")]
        public async Task<ActionResult<IEnumerable<AsiaModel>>> Asia()
        {
            return await _context.AsiaCountries.ToListAsync();
        }


        [HttpGet]
        [Route("api/[controller]/asia/{id}")]
        public async Task<ActionResult<AsiaModel>> AsiaId(int? id)
        {
            return await _context.AsiaCountries.FindAsync(id);
        }
    }
}
