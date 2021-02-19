using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Models
{
    public class Origenes_Destino
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [Required(ErrorMessage = "'Pais' is required")]
        public string Pais { get; set; }
        public string Ciudad { get; set; }

    }
}
