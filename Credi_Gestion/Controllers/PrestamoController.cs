using Credi_Gestion.Data;
using Credi_Gestion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Credi_Gestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PrestamoController(MyDbContext context)
        {
            _context = context;
        }



        // GET: api/<PrestamoController>
        [HttpGet]
        public IEnumerable<Prestamo> Get()
        {
            IEnumerable<Prestamo> prestamo = _context.Prestamo.ToList();
            return prestamo;
        }

        // GET api/<PrestamoController>/5
        [HttpGet("{id}")]
        public Prestamo Get(int id)
        {
            Prestamo prestamo = _context.Prestamo.Where(a => a.IdPrestamo == id).FirstOrDefault();

            if (prestamo == null)
                return new Prestamo();
            return prestamo;
        }

        // POST api/<PrestamoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PrestamoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PrestamoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
