using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        private readonly DataContext _context;
        public StatusController(DataContext context)
        {
            _context=context;
        }

        // GET api/status
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SAstatus>>> Get()
        {
            var status =await _context.Status.ToListAsync();
            return Ok(status);
        }

        // GET api/status/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SAstatus>> Get(int id)
        {
            var status =await _context.Status.FindAsync(id);
            return Ok(status);
           
        }

        // POST api/status
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/status/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/status/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
