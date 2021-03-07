using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;
using Backend.Vuelos.Repositories;
using Backend.Vuelos.Models;

namespace Backend_Vuelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrigenesDestinoController : ControllerBase
    {
        private readonly OrigenesRepositories _origenes;
        private readonly DestinosRepositories _destinos;

        public OrigenesDestinoController(OrigenesRepositories origenes, DestinosRepositories destinos)
        {
            this._origenes = origenes;
            this._destinos = destinos;
        }

        /// <summary>
        /// API comunicarse con los repositorios
        /// </summary>
        /// <returns> Obtieene todos los origenes que esten disponibles.</returns>

        [HttpGet]
        public ActionResult<List<Origenes>> Get() =>
            _origenes.getOrigenes();

        /// <summary>
        /// API comunicarse con los repositorios
        /// </summary>
        /// <returns> Obtieene todos los destinos que esten disponibles.</returns>
        [HttpGet("GetDestinations")]
        public async Task<ActionResult<List<Destinos>>> GetDestinations() {
            return await _destinos.getDestinations();

        }

        [HttpPost("getByDestination")]
        public async Task<List<Destinos>> getByDestination([FromBody] Destinos destinos)//debe retornar vuelos
        {
            return await _destinos.getVuelosByDestination(destinos);
        }

    }

}
