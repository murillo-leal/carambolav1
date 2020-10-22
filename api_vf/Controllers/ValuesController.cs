using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Mensagem.Models;
using Microsoft.Data.SqlClient;


namespace api_vf.Controllers
{
    [Route("/fundo-investimentos/v1/carambola")]
    public class ValuesController : ControllerBase
    {
        
        [HttpGet]
       public IActionResult Get()
        {
            // Alimentando o objeto dentro do get
            return Ok(new Texto {data = (new Msg {Mensagem = "Objetivo primeira semana concluído com SUCESSO!! =)"})});
            
        }
    }
}
