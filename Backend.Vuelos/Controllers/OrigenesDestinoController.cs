using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;
using Backend.Vuelos.Repositories;

namespace Backend_Vuelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrigenesDestinoController : ControllerBase
    {
        private readonly Origenes_Destino_Repositories _origenes_destino;

        public OrigenesDestinoController(Origenes_Destino_Repositories origenes_destino)
        {
            _origenes_destino = origenes_destino;
        }

        [HttpGet]//Obtieene todos los origenes/destino que esten disponibles.
        public ActionResult<List<Origenes_Destino>> Get() =>
            _origenes_destino.getOrigen_Destino();
    }
}
