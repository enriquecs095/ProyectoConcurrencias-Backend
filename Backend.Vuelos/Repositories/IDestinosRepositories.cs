using Backend.Vuelos.Models;
using Backend_Vuelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public interface IDestinosRepositories
    {
        public Task<List<Destinos>> getDestinations();
        public Task<List<Destinos>> getVuelosByDestination(Destinos destinos);//hay que cambiarlo a vuelos
    }
}
