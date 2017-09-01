using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Interfases;

namespace Epm.EstamosAhi.Infraestructura.Servicios
{
    public class ClienteRest : IClienteRest
    {

        public async Task<HttpResponseMessage> ObtenerDatosGetAsincronos(string serviceUrl)
        {
            using (var client = new HttpClient())
            {
                return await client.GetAsync(new Uri(serviceUrl));
            }
        }

        public async Task<HttpResponseMessage> ObtenerDatosGetAsincronosConEncabezados(string serviceUrl, Dictionary<string, string> headers = null)
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var item in headers)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }

                return await client.GetAsync(new Uri(serviceUrl));
            }
        }

        public async Task<HttpResponseMessage> ObtenerDatosPostAsincronos(string serviceUrl, HttpContent parametros)
        {
            using (var client = new HttpClient())
            {
                return await client.PostAsync(new Uri(serviceUrl), parametros);
            }
        }

        public async Task<HttpResponseMessage> ObtenerDatosPostAsincronosConEncabezados(string serviceUrl, Dictionary<string, string> headers, HttpContent parametros)
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var item in headers)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }

                return await client.PostAsync(new Uri(serviceUrl), parametros);
            }
        }
    }
}
