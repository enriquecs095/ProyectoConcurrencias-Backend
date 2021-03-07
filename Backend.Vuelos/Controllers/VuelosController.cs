using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;
using Backend_Vuelos.Repositories;
using Backend.Vuelos.Repositories;

namespace Backend_Vuelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VuelosController : Controller
    {
        private readonly VuelosRepositories _vuelos;
        private readonly Origenes_Destino_Repositories _origenes_destino;



        public VuelosController(VuelosRepositories vuelos, Origenes_Destino_Repositories origenes_destino)
        {
            _vuelos = vuelos;
            _origenes_destino = origenes_destino;
        }

        [HttpGet]//obtiene todos los vuelos disponibles
        public ActionResult<List<Vuelo>> Get() =>
        _vuelos.getVuelos();


        [HttpPost("getByOrigin")]
        public ActionResult<List<Vuelo>> getByOrigin([FromBody] Origenes_Destino origin) {

            return _origenes_destino.getVuelosByOrigin(origin);

        }

        [HttpPost("getByDestination")]
        public ActionResult<List<Vuelo>> getByDestination([FromBody] Origenes_Destino origin) {

            return _origenes_destino.getVuelosByDestination(origin);
        }

        [HttpGet("getByDate/date")]
        public ActionResult<List<Vuelo>> getByDate(string date) =>
            _vuelos.getVuelosByDate(date);


        [HttpPost("getByRange/{minimumRange}/{maximumRange}")]
        public ActionResult<List<Vuelo>> getByRange(double minimumRange, double maximumRange) =>
                _vuelos.getVuelosByRange(minimumRange, maximumRange);
    }

}
