using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;
using Backend_Vuelos.Services;

namespace Backend_Vuelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrigenesDestinoController : ControllerBase
    {
        private readonly ConcurrenciaServices _origenes_destino;

        public OrigenesDestinoController(ConcurrenciaServices origenes_destino)
        {
            _origenes_destino = origenes_destino;
        }

        [HttpGet("getAll")]//Obtieene todos los origenes/destino que esten disponibles.
        public ActionResult<List<Origenes_Destino>> getOrigen_Destino() =>
            _origenes_destino.getOrigen_Destino();
    }
}
