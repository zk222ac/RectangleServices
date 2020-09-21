using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RectangleServices.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RectangleServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RectangleController : ControllerBase
    {
        // GET: api/<RectangleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RectangleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RectangleController>
        [HttpPost ("AreaRectangle" , Name = "AreaRectangle")]
        public int Post([FromBody] AreaRec rect)
        {
            return rect.Length * rect.Width;
        }

        
        // PUT api/<RectangleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RectangleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
