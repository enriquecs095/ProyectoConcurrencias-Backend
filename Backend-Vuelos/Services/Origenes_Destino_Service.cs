using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Vuelos.Models;


namespace Backend_Vuelos.Services
{
    public class Origenes_Destino_Service
    {
        private readonly IMongoCollection<Origenes_Destino> _origenes;
        private readonly ConnectionDB _settings;
        public Origenes_Destino_Service(IOptions<ConnectionDB> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _origenes = database.GetCollection<Origenes_Destino>(_settings.CustomerCollectionName);
        }

        public async Task<List<Origenes_Destino>> GetAllAsync()
        {
            return await _origenes.Find(c => true).ToListAsync();
        }
        public async Task<Origenes_Destino> GetByIdAsync(int id)
        {
            return await _origenes.Find<Origenes_Destino>(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Origenes_Destino> CreateAsync(Origenes_Destino origenes_destino)
        {
            await _origenes.InsertOneAsync(origenes_destino);
            return origenes_destino;
        }
        public async Task UpdateAsync(int id, Origenes_Destino customer)
        {
            await _origenes.ReplaceOneAsync(c => c.Id == id, customer);
        }
        public async Task DeleteAsync(int id)
        {
            await _origenes.DeleteOneAsync(c => c.Id == id);
        }

    }

}
