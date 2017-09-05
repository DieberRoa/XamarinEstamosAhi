using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Dto;
using Epm.EstamosAhi.Infraestructura.Recursos;

namespace Epm.EstamosAhi.Core.Repositorio.Local
{
    public class RepositorioLogin 
    {
        private RespuestaLogin Autenticar(SolicitudLogin solicitud)
        {
            if (solicitud == null)
            {
                throw new ArgumentNullException(Recursos.ObtenerValorConLlave("nombreParametroAutenticar"));
            }
            RespuestaLogin salida = new RespuestaLogin();
            salida.Respuesta = new System.Net.Http.HttpResponseMessage();
            if (solicitud.CorreoElectronico == @"droa@intergrupo.com" && solicitud.Contrasenia=="Cool1976."){
                salida.Respuesta.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else{
                salida.Respuesta.StatusCode = System.Net.HttpStatusCode.Unauthorized;
            }
            return salida;

        }

      


    }
}
