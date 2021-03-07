using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;
using Backend_Vuelos.Repositories;
using Backend.Vuelos.Repositories;
using Backend.Vuelos.Models;

namespace Backend_Vuelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VuelosController : Controller
    {
        private readonly VuelosRepositories _vuelos;
        private readonly OrigenesRepositories _origenes;



        public VuelosController(VuelosRepositories vuelos, OrigenesRepositories origenes)
        {
            _vuelos = vuelos;
            _origenes = origenes;
        }

        [HttpGet]//obtiene todos los vuelos disponibles
        public ActionResult<List<Vuelo>> Get() =>
        _vuelos.getVuelos();


        [HttpPost("getByOrigin")]
        public ActionResult<List<Vuelo>> getByOrigin([FromBody] Origenes origin) {
            return _origenes.getVuelosByOrigin(origin);
        }
        

        [HttpGet("getByDate/date")]
        public ActionResult<List<Vuelo>> getByDate(string date) =>
            _vuelos.getVuelosByDate(date);


        [HttpPost("getByRange/{minimumRange}/{maximumRange}")]
        public ActionResult<List<Vuelo>> getByRange(double minimumRange, double maximumRange) =>
                _vuelos.getVuelosByRange(minimumRange, maximumRange);
    }

}
