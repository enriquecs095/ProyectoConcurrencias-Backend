using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;

namespace Backend_Vuelos.Services
{
    public class Vuelos_Service
    {
        private readonly IMongoCollection<Vuelos> _origenes;
        private readonly ConnectionDB _settings;
        public Vuelos_Service(IOptions<ConnectionDB> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _origenes = database.GetCollection<Vuelos>(_settings.CustomerCollectionName);
        }

        public async Task<List<Vuelos>> GetAllAsync()
        {
            return await _origenes.Find(c => true).ToListAsync();
        }
        public async Task<Vuelos> GetByIdAsync(int id)
        {
            return await _origenes.Find<Vuelos>(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Vuelos> CreateAsync(Vuelos origenes_destino)
        {
            await _origenes.InsertOneAsync(origenes_destino);
            return origenes_destino;
        }
        public async Task UpdateAsync(int id, Vuelos vuelos)
        {
            await _origenes.ReplaceOneAsync(c => c.Id == id, vuelos);
        }
        public async Task DeleteAsync(int id)
        {
            await _origenes.DeleteOneAsync(c => c.Id == id);
        }

    }
}
