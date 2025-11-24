using BackendReciclarsipaga.Models;
using BackendReciclarsipaga.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendReciclarsipaga.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PuntosController : Controller
    {
        private readonly IPuntosService _puntosService;

        public PuntosController(IPuntosService puntosService)
        {
            _puntosService = puntosService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puntos>>> GetPuntos()
        {
            var puntos = await _puntosService.GetAllAsync();
            return Ok(puntos);
        }

        [HttpPost("agregar")]
        public async Task<IActionResult> AgregarPuntos([FromBody] Puntos puntosDto)
        {
            var exito = await _puntosService.AgregarPuntosAsync(puntosDto.idUsuario, puntosDto.puntos);

            if (!exito)
                return NotFound($"Usuario con ID {puntosDto.idUsuario} no encontrado.");

            return Ok(new { mensaje = "Puntos actualizados correctamente" });
        }


    }
}
