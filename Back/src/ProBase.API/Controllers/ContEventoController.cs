using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProBase.API.Models;

namespace ProBase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContEventoController : ControllerBase
    {
       
        public IEnumerable<ContEvento> _evento = new ContEvento[] 
        {
            
                 new ContEvento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .net5",
                    Local = "SP",
                    Lote = "1 Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()

                },
                 new ContEvento(){
                    EventoId = 2,
                    Tema = "Festa",
                    Local = "SP",
                    Lote = "2 Lote",
                    QtdPessoas = 230,
                    DataEvento = DateTime.Now.AddDays(2).ToString()

                }
                
        };
        public ContEventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<ContEvento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<ContEvento> GetById(int id)
        
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        
        [HttpPost]
        public string Post()
        {
            return "PostRodou";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put com id {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de put com id {id}";
        }
    }
}
