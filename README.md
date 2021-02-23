# ProyectoConcurrencias-Backend


-EndPoints-
|     URL              |  Param |                       Retorno                                      |  Descripción                                                  | 

Vuelos/getByOrigin     |        | {  "pais": "string",  "ciudad": "string"} |                        | Retorna los vuelos segun el origen
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
                                 
