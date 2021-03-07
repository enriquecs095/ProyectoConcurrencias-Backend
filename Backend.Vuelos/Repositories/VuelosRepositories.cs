using Backend.Vuelos.Repositories;
using Backend_Vuelos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Repositories
{

    public class VuelosRepositories : IVuelosRepositories
    {
        // GET: ConcurrenciaServices
        private readonly IMongoCollection<Vuelo> _vuelos;

        public VuelosRepositories(IConcurrenciaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _vuelos = database.GetCollection<Vuelo>("Vuelos");
        }

        public List<Vuelo> getVuelos() =>
             _vuelos.Find(book => true).ToList();


        // MinSupportedDateTime = {1/1/0001 12:00:00 AM
        public List<Vuelo> getVuelosByDate(string date)
        {//12/25/2015 12:00:00 AM
            DateTime oDate = DateTime.ParseExact(date, "M/d/yyyy HH:mm tt", null);
            return _vuelos.Find(x => x.Fecha == oDate).ToList();
        }

        public List<Vuelo> getVuelosByRange(double minumum, double maximum) =>
                _vuelos.Find(x => x.Precio >= minumum && x.Precio <= maximum).ToList();
    }
}
