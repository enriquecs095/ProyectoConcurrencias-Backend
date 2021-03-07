using Backend_Vuelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public interface IOrigenesRepositories
    {
        List<Vuelo> getVuelosByOrigin(Origenes origin);
        List<Origenes> getOrigenes();

        Origenes Create(Origenes origen);
    }
}
