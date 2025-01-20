using GestAct.Data;
using GestAct.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace GestAct.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController :ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public AdminController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        //Retourne tous les utilisateurs de la BD
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList()
                .Select(s =>s.UserDto());
            return Ok(users);
        }

        [HttpGet("{id}")]
        //Retourne un seul User de la BD
        public IActionResult GetById([FromRoute] int id)
        {
            var user = _context.Users.Find(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user.UserDto());
        }
    }
}
