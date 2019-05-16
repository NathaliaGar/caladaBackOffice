using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalveMariaBackoffice.Data;
using SalveMariaBackoffice.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalveMariaBackoffice.Controllers
{
    [Route("api/[controller]")]
    public class AlertasController : Controller
    {

        private ApplicationDbContext _context;
        

        public AlertasController(ApplicationDbContext context)
        {
            _context = context;
            
        }


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Alertas> Get()
        {
            return _context.Alertas.ToList();

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Alertas alertas)
        {
            //Db
            _context.Alertas.Add(alertas);
            _context.SaveChanges();

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
