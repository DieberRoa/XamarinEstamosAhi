using System.Net.Http;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface IJotason
    {
        T Deserializar<T>(string text);
        Task<TResponse> ObtenerRespuestaSerializada<TResponse>(HttpResponseMessage result);
        string Serializar(object obj);
    }
}