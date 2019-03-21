using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Input;
using API.Models;
using API.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class CampeonatoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [EnableCors("AllowMyOrigin")]
        public  ResultadoCampeonato Post([FromBody] FilmeInput[] filmes)
        {
            Campeonato campeonato = new Campeonato(filmes);
            var resultado =  campeonato.Iniciar();

            return resultado;
        }
    }
}