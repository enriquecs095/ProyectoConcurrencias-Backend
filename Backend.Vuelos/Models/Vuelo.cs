using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Models
{
    public class Vuelo
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int Disponibilidad { get; set; }
        public Origenes_Destino Lugar_Origen { get; set; }
        public Origenes_Destino Lugar_Destino { get; set; }
        public int Clase { get; set; }
        public double Precio { get; set; }  
        public string Aerolinea { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

    }
}
