using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using UsedCars.Models;
using UsedCars.Models.CreatedModels;
using System.Data.Entity;
using UsedCars.DTOs;
using AutoMapper;

namespace UsedCars.Controllers.API
{
    public class ClientsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<ClientDto> AllClients()
        {
            return _context.Clients.ToList().Select(Mapper.Map<Client, ClientDto>);
        }

        [HttpGet]
        public IHttpActionResult GetClient(int Id)
        {
            var client = _context.Clients.FirstOrDefault(n => n.Id == Id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Client, ClientDto>(client));
        }

        [HttpPost]
        public IHttpActionResult CreateClient(ClientDto clientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var client = Mapper.Map<ClientDto, Client>(clientDto);

            _context.Clients.Add(client);
            _context.SaveChanges();

            clientDto.Id = client.Id;

            return Created(new Uri(Request.RequestUri + "/" + client.Id), clientDto);
        }

        [HttpPut]
        public void UpdateClient(int Id, ClientDto clientDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var clientInDb = _context.Clients.FirstOrDefault(n => n.Id == Id);

            if (clientInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(clientDto, clientInDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteClient(int Id)
        {
            var clientInDb = _context.Clients.FirstOrDefault(n => n.Id == Id);

            if (clientInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Clients.Remove(clientInDb);
            _context.SaveChanges();
        }
    }
}