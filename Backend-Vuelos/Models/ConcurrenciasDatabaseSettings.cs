using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Vuelos.Models {
    public class ConcurrenciaDatabaseSettings:IConcurrenciaDatabaseSettings {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
      
    }
    public interface IConcurrenciaDatabaseSettings {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
