using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface IClienteRest
    {
        Task<HttpResponseMessage> ObtenerDatosGetAsincronos(string serviceUrl);
        Task<HttpResponseMessage> ObtenerDatosGetAsincronosConEncabezados(string serviceUrl, Dictionary<string, string> headers = null);
        Task<HttpResponseMessage> ObtenerDatosPostAsincronos(string serviceUrl, HttpContent parametros);
        Task<HttpResponseMessage> ObtenerDatosPostAsincronosConEncabezados(string serviceUrl, Dictionary<string, string> headers, HttpContent parametros);

    }
}