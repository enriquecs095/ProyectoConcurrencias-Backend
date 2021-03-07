using Backend_Vuelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public interface IOrigenes_Destino_Repositories
    {
        List<Vuelo> getVuelosByOrigin(Origenes_Destino origin);
        List<Vuelo> getVuelosByDestination(Origenes_Destino origin);
        List<Origenes_Destino> getOrigen_Destino();

        Origenes_Destino Create(Origenes_Destino origen);
    }
}
