using ApiLinq.Controllers.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLinq.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        [Route("[action]")]
        [HttpPost]
        public IEnumerable<string> OrdemAlfabetica([FromBody] ListaPalavrasDTO request)
        {
            return request.Palavras.OrderBy(x => x);
        }

        [Route("[action]")]
        [HttpPost]
        public IEnumerable<string> TamanhoDecrescente([FromBody] ListaPalavrasDTO request)
        {
            return request.Palavras.OrderByDescending(x => x.Length);
        }

        [Route("[action]")]
        [HttpPost]
        public IEnumerable<string> TamanhoCrescente([FromBody] ListaPalavrasDTO request)
        {
            return request.Palavras.OrderBy(x => x.Length);
        }
    }
}
