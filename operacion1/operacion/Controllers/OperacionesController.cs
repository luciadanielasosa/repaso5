using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace operacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        [HttpGet]

        public string funcion (int numero)
        {
            string texto = "";
            if (numero > 0)
            {
                texto = "Usted ingresó el número  " + numero;
            }
            if (numero < 0)
            {
                texto = "ERROR";
            }
            if (numero == 0)
            {
                texto = "Realizado por Lucia Sosa";
            }
            return texto;

        }
        [HttpPost]

        public string funcion1([FromHeader]int numero)
        {
            string texto = "";
            if (numero > 0)
            {
                texto = "Usted ingresó el número  " + numero;
            }
            if (numero < 0)
            {
                texto = "ERROR";
            }
            if (numero == 0)
            {
                texto = "Realizado por Lucia Sosa";
            }
            return texto;

        }
    }
}
