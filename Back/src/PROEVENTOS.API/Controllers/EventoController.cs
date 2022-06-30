using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        private IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdePessoas = 500,
                    DataEvento = DateTime.Now.AddDays(7).ToString()
                }
            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(long id)
        {
            return _evento.Where(x=>x.EventoId == id);
        }
    }
}
