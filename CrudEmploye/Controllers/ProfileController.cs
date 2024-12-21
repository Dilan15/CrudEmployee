using CrudEmploye.Context;
using CrudEmploye.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudEmploye.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProfileController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("lista")]
        
        public async Task<ActionResult<List<Profile>>> GetProfile()
        {
            var profileList = await _context.Profiles.ToListAsync();

            return Ok(profileList); 
        }
    }
}
