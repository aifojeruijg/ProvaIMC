using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_IMC.Models;
using Microsoft.AspNetCore.Mvc;
using API.Utils;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers 
{
    [ApiController]
    [Route("api/imc")]
    public class ImcController : ControllerBase
    {
        private readonly Context _context;
        public ImcController (Context context) => 
            _context = context;


        //CADASTRAR IMC
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Imc imc)
        {
            imc.ImcFinal =
                Calculos.CalcularIMC (imc.Peso, imc.Altura);
            imc.Categoria = 
                Calculos.CalcularCategoria (imc.ImcFinal);

            _context.Imcs.Add(imc);
            _context.SaveChanges();
            return Created("", imc);
        }

        //LISTAR Imcs
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Imc> imcs = _context.Imcs
             .Include(x => x.Usuario).ToList();

             if(imcs.Count == 0) return NotFound();
             
             return Ok(imcs);
        }

        //BUSCAR pelo Id
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Imc imc = _context.Imcs.Find(id);
            return imc != null ? Ok(imc) : NotFound();
        }

        //ALTERAR 
        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Imc imc)
        {
            _context.Imcs.Update(imc);
            _context.SaveChanges();
            return Ok(imc);
        }

    }
}