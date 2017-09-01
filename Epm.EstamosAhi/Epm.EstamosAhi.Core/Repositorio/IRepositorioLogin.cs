using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Dto;

namespace Epm.EstamosAhi.Core.Repositorio
{
    public interface IRepositorioLogin
    {
        RespuestaLogin Autenticar(SolicitudLogin solicitud);
    }
}
