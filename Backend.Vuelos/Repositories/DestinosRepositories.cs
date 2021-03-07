using Backend.Vuelos.Models;
using Backend_Vuelos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Backend.Vuelos.Repositories
{
    public class DestinosRepositories: IDestinosRepositories
    {
        private readonly HttpClient _httpClient;

        public DestinosRepositories(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<Destinos>> getDestinations()
        {
            var content = await _httpClient.GetStringAsync($"/api/Destinations");
            return JsonConvert.DeserializeObject<List<Destinos>>(content);
        }

        public async Task<List<Destinos>> getVuelosByDestination(Destinos destinos)//hay que cambiarlo a vuelos
        {
            var content = await _httpClient.PostAsync($"/api/Destinations/FindFlightsByDestinations", new StringContent(JsonConvert.SerializeObject(destinos)));
            content.EnsureSuccessStatusCode();
            var response = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Destinos>>(response);
        }

  
        // var resultado = _vuelos.Find(x => x.Lugar_Destino.Ciudad == origin.Ciudad && x.Lugar_Destino.Pais == origin.Pais).ToList();
        //     return resultado;


    }
}
