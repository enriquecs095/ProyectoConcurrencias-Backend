using Backend_Vuelos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Services {
    public class ConcurrenciaServices {
        // GET: ConcurrenciaServices
        private readonly IMongoCollection<Origenes_Destino> _origenes;
        private readonly IMongoCollection<Vuelos> _vuelos;

        // private readonly IMongoCollection<Origenes_Destino> _origenes;

        public ConcurrenciaServices(IConcurrenciaDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _origenes = database.GetCollection<Origenes_Destino>("Origenes_Destino");
            _vuelos = database.GetCollection<Vuelos>("Vuelos");
        }

        public List<Origenes_Destino> getOrigen_Destino() =>
               _origenes.Find(book => true).ToList();
        public Origenes_Destino Create(Origenes_Destino origen) {
            _origenes.InsertOne(origen);
            return origen;
        }
        public List<Vuelos> getVuelos() =>
             _vuelos.Find(book => true).ToList();
        public List<Vuelos> getVuelosByOrigin(Origenes_Destino origin) {
            var resultado = _vuelos.Find(x => x.Lugar_Origen.Ciudad == origin.Ciudad && x.Lugar_Origen.Pais == origin.Pais).ToList();
            return resultado;
        }
        public List<Vuelos> getVuelosByDestination(Origenes_Destino origin) {
            var resultado = _vuelos.Find(x => x.Lugar_Destino.Ciudad == origin.Ciudad && x.Lugar_Destino.Pais == origin.Pais).ToList();
            return resultado;
        }
       // MinSupportedDateTime = {1/1/0001 12:00:00 AM
    public List<Vuelos> getVuelosByDate(string date) {//12/25/2015 12:00:00 AM
            DateTime oDate = DateTime.ParseExact(date, "M/d/yyyy HH:mm tt", null);
            return _vuelos.Find(x =>x.Fecha == oDate).ToList();
        }
        public List<Vuelos> getVuelosByRange(double minumum, double maximum) =>
                _vuelos.Find(x => x.Precio >= minumum && x.Precio <= maximum).ToList();
    }
}
