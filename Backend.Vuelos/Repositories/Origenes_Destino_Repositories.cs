using Backend_Vuelos.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public class Origenes_Destino_Repositories
    {
        private readonly IMongoCollection<Origenes_Destino> _origenes;
        private readonly IMongoCollection<Vuelo> _vuelos;

        // private readonly IMongoCollection<Origenes_Destino> _origenes;

        public Origenes_Destino_Repositories(IConcurrenciaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _origenes = database.GetCollection<Origenes_Destino>("Origenes_Destino");
            _vuelos = database.GetCollection<Vuelo>("Vuelos");
        }


        public List<Vuelo> getVuelosByOrigin(Origenes_Destino origin)
        {
            var resultado = _vuelos.Find(x => x.Lugar_Origen.Ciudad == origin.Ciudad && x.Lugar_Origen.Pais == origin.Pais).ToList();
            return resultado;
        }

        public List<Vuelo> getVuelosByDestination(Origenes_Destino origin)
        {
            var resultado = _vuelos.Find(x => x.Lugar_Destino.Ciudad == origin.Ciudad && x.Lugar_Destino.Pais == origin.Pais).ToList();
            return resultado;
        }

        public List<Origenes_Destino> getOrigen_Destino() =>
            _origenes.Find(book => true).ToList();

        public Origenes_Destino Create(Origenes_Destino origen)
        {

            _origenes.InsertOne(origen);
            return origen;
        }

    }
}
