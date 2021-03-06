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
    public class VuelosController : Controller
    {
        private readonly ConcurrenciaServices _vuelos;

        public VuelosController(ConcurrenciaServices vuelos)
        {
            _vuelos = vuelos;
        }

        [HttpGet("getAll")]//obtiene todos los vuelos disponibles
        public ActionResult<List<Vuelos>> getVuelos() =>
        _vuelos.getVuelos();

        [HttpPost("getByOrigin")]
        public ActionResult<List<Vuelos>> getByOrigin([FromBody] Origenes_Destino origin) {
            return _vuelos.getVuelosByOrigin(origin);

        }
        [HttpPost("getByDestination")]
        public ActionResult<List<Vuelos>> getByDestination([FromBody] Origenes_Destino origin) {
            return _vuelos.getVuelosByDestination(origin);
        }
        [HttpGet("getByDate/date")]
        public ActionResult<List<Vuelos>> getByDate(string date) =>
            _vuelos.getVuelosByDate(date);

        [HttpPost("getByRange/{minimumRange}/{maximumRange}")]
        public ActionResult<List<Vuelos>> getByRange(double minimumRange, double maximumRange) =>
                _vuelos.getVuelosByRange(minimumRange, maximumRange);
    }
}
