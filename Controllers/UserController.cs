using GestAct.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestAct.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
