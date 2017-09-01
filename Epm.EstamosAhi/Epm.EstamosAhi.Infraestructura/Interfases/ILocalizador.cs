
namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface ILocalizador
    {
        T ObtenerClase<T>() where T : class;
    }
}
