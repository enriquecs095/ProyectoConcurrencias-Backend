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

    }
}
