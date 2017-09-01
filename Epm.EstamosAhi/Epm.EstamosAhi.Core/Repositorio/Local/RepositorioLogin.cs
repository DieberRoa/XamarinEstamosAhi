using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Dto;
using Epm.EstamosAhi.Infraestructura.Recursos;

namespace Epm.EstamosAhi.Core.Repositorio.Local
{
    public class RepositorioLogin : IRepositorioLogin
    {
        public RespuestaLogin Autenticar(SolicitudLogin solicitud)
        {
            if (solicitud == null)
            {
                throw new ArgumentNullException(Recursos.ObtenerValorConLlave("nombreParametroAutenticar"));
            }

            return new RespuestaLogin() { Token = new Guid().ToString() };
        }
    }
}
