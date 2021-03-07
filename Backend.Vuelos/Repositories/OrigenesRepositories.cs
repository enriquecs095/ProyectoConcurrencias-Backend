using Backend.Vuelos.Models;
using Backend_Vuelos.Models;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public class OrigenesRepositories: IOrigenesRepositories
    {
        private readonly IMongoCollection<Origenes> _origenes;
        private readonly IMongoCollection<Vuelo> _vuelos;
        private readonly HttpClient _httpClient;

        // private readonly IMongoCollection<Origenes_Destino> _origenes;

        public OrigenesRepositories(IConcurrenciaDatabaseSettings settings, HttpClient httpClient)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _origenes = database.GetCollection<Origenes>("Origenes_Destino");
            _vuelos = database.GetCollection<Vuelo>("Vuelos");
            this._httpClient = httpClient;
        }

   
        public List<Vuelo> getVuelosByOrigin(Origenes origin)
        {
            var resultado = _vuelos.Find(x => x.Lugar_Origen.Ciudad == origin.Ciudad && x.Lugar_Origen.Pais == origin.Pais).ToList();
            return resultado;
        }

        public List<Origenes> getOrigenes() =>
            _origenes.Find(book => true).ToList();


        public Origenes Create(Origenes origen)
        {
            _origenes.InsertOne(origen);
            return origen;
        }

  
    }
}
