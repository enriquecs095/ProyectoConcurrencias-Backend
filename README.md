# ProyectoConcurrencias-Backend


-EndPoints-
|     URL              |  Param |                       Retorno                                      |  Descripción                                                  | 

| Vuelos/getAll | None | [
  {
    "id": "6029b87ab1b88c1ff0992d92",
    "disponibilidad": 80,
    "lugar_Origen": {
      "id": "60300cf21a60327fb57339e6",
      "pais": "Guatemala",
      "ciudad": "Antigua Guatemala"
    },
    "lugar_Destino": {
      "id": "60300cf21a60327fb57339e6",
      "pais": "Honduras",
      "ciudad": "San Pedro Sula"
    },
    "clase": 0,
    "precio": 0,
    "aerolinea": "AA",
    "descripcion": "La mejor",
    "fecha": "2015-09-01T15:20:00Z"
  }
] | Retorna Todos los vuelos disponibles que existan
                                      

Vuelos/getByDestination  |        | {  "pais": "string",  "ciudad": "string"} |                        | Retorna los vuelos segun el destino
                                        {    "id": "string",
                                        "disponibilidad": 0,
                                        "lugar_Origen": {
                                        "id": "string",
                                        "pais": "string",
                                        "ciudad": "string"
                                        },
                                        "lugar_Destino": {
                                           "id": "string",
                                           "pais": "string",
                                           "ciudad": "string"
                                         },
                                         "clase": 0,
                                         "precio": 0,
                                         "aerolinea": "string",
                                         "descripcion": "string",
                                         "fecha": "2021-02-23T04:37:03.923Z"
                                      }
                                                                    


Vuelos/getAll               |        | {  "pais": "string",  "ciudad": "string"} |                        | Retorna todos los vuelos
                                        {    "id": "string",
                                        "disponibilidad": 0,
                                        "lugar_Origen": {
                                        "id": "string",
                                        "pais": "string",
                                        "ciudad": "string"
                                        },
                                        "lugar_Destino": {
                                           "id": "string",
                                           "pais": "string",
                                           "ciudad": "string"
                                         },
                                         "clase": 0,
                                         "precio": 0,
                                         "aerolinea": "string",
                                         "descripcion": "string",
                                         "fecha": "2021-02-23T04:37:03.923Z"
                                      }

Vuelos/getByDate/date | date | { "id": "string",                                                            | retorna todos los vuelos segun la fecha recibida por parametro
                                 "disponibilidad": 0,
                                 "lugar_Origen": {
                                 "id": "string",
                                 "pais": "string",
                                 "ciudad": "string"
                                 },
                                 "lugar_Destino": {
                                 "id": "string",
                                 "pais": "string",
                                 "ciudad": "string"
                                 },
                                 "clase": 0,
                                 "precio": 0,
                                 "aerolinea": "string",
                                 "descripcion": "string",
                                 "fecha": "2021-02-23T04:39:38.207Z"
                                 }
                                 
