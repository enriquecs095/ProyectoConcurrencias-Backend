using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Vuelos.Models
{
    public class Destinos
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Cities[] City;

    }
}
