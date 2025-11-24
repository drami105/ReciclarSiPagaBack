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


    }
}
