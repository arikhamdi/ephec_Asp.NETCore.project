using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetWeb.Models;
using projetWeb.Repositories;

namespace projetWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstablishmentsController : Controller
    {
        private readonly IEstablishmentRepository establishmentRepository = null;

        public EstablishmentsController(IEstablishmentRepository establishmentRepository)
        {
            this.establishmentRepository = establishmentRepository;
        }

        // GET: api/Establishments
        [HttpGet]
        public List<Establishment> Get()
        {
            return establishmentRepository.SelectAll();
        }

        // GET: api/Establishments/5
        [HttpGet("{id}")]
        public Establishment Get(int id)
        {
            return establishmentRepository.SelectByID(id);
        }

        // POST: api/Establishments
        [HttpPost]
        public void Post(Establishment est)
        {
            if (ModelState.IsValid)
            {
                establishmentRepository.Insert(est);
            }
        }

        // PUT: api/Establishments/5
        [HttpPut("{id}")]
        public void Put(int id, Establishment est)
        {
            if (ModelState.IsValid)
            {
                establishmentRepository.Update(est);
            }
        }

        

        // DELETE: api/Establishments/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            establishmentRepository.Delete(id);
        }
    }
}
