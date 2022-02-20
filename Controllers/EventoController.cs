﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento =    new Evento[] {

              new  Evento (){
                EventoId= 1,
                Tema  = "Angular 11 e .Net 5",
                Local = "belo Horizonte",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"

            }, new  Evento (){
                EventoId= 2,
                Tema  = "Angular 11 e .Net 5 e SqlLite",
                Local = "Rio de Janeiro",
                Lote = "100º lote",
                QtdPessoas = 1000,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"

            }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _evento;
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return  _evento.Where(evento => evento.EventoId == id);
            
        }
           
       
        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
           
        }

         [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put com id  = {id}";
           
        }

         [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
           
        }
    }
}


