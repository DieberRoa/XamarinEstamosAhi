using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Epm.EstamosAhi.Infraestructura.Dto
{
    public class RespuestaLogin
    {
        public string Token { get; set; }
        public HttpResponseMessage Respuesta { get; set; }
    }
}
