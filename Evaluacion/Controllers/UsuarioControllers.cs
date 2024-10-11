using Microsoft.AspNetCore.Mvc;
using Evaluacion.Models;


namespace Evaluacion.Controllers
{
    public class UsuarioControllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private readonly YourDbContext _context;

            public UserController(YourDbContext context)
            {
                _context = context;
            }

            // Ejemplo: Obtener todos los usuarios
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Usuario>>> GetUsers()
            {
                return await _context.Users.ToListAsync();
            }

            // Ejemplo: Crear un usuario
            [HttpPost]
            public async Task<ActionResult<Usuario>> CreateUser(Usuario user)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUsuario), new { id = user.Id }, user);
            }

            // Otros métodos CRUD aquí
        }
    }
