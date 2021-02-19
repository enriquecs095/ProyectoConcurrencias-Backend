using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;

namespace Backend_Vuelos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : Controller
    {
        private readonly Origenes_Destino _origenes_destino;

        public VuelosController(Origenes_Destino origenes_destino)
        {
            _origenes_destino = origenes_destino;
        }


    }
}
