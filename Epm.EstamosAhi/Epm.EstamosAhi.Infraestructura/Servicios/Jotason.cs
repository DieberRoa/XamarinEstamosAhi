using Epm.EstamosAhi.Infraestructura.Interfases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Servicios
{
    public class Jotason : IJotason
    {
        public async Task<TResponse> ObtenerRespuestaSerializada<TResponse>(HttpResponseMessage result)
        {
            string response = await result.Content.ReadAsStringAsync();
            TResponse serializedResponse = JsonConvert.DeserializeObject<TResponse>(response);
            return serializedResponse;
        }

        public T Deserializar<T>(string text)
        {
            T deserializedObject = JsonConvert.DeserializeObject<T>(text);
            return deserializedObject;
        }
        public string Serializar(object obj)
        {
            string serializedObject = JsonConvert.SerializeObject(obj);
            return serializedObject;
        }
    }
}
