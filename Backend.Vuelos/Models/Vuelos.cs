using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Models
{
    public class Vuelos
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int Disponibilidad { get; set; }
        public object Lugar_Origen { get; set; }
        public object Lugar_Destino { get; set; }
        public int Clase { get; set; }
        public int Precio { get; set; }  
        public string Aerolinea { get; set; }
        public string Descripcion { get; set; }

    }
}
