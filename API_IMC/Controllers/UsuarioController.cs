using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_IMC.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly Context _context;
        public UsuarioController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }


        
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Usuario> Usuarios = _context.Usuarios.ToList();
            return Usuarios.Count != 0 ? Ok(Usuarios) : NotFound();
        }
    }
}