using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;

namespace Backend.Vuelos.Repositories
{
    public interface IVuelosRepositories
    {
        List<Vuelo> getVuelos();

        List<Vuelo> getVuelosByDate(string date);

        List<Vuelo> getVuelosByRange(double minumum, double maximum);

    }
}
