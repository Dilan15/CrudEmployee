using CrudEmploye.Context;
using CrudEmploye.DTOs;
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
        
        public async Task<ActionResult<List<ProfileDTO>>> GetProfile()
        {
            var DtoList = new List<ProfileDTO>();
            var DbList = await _context.Profiles.ToListAsync();

            foreach (var item in DbList)
            {
                DtoList.Add(new ProfileDTO
                {
                    IdProfile = item.IdProfile,
                    Name = item.Name,
                });
            }    

            return Ok(DbList); 
        }
    }
}
