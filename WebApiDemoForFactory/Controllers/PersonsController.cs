using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using NLog.Fluent;
using WebApiDemoForFactory.Models;
using WebApiDemoForFactory.Models.Constants;
using WebApiDemoForFactory.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemoForFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly Logger Logger;
        public readonly IPersonService PersonService;
        public PersonsController(IPersonService service)
        {
            PersonService = service;
            Logger = NLog.LogManager.GetCurrentClassLogger();
        }
        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            PersonService.GetPersons(ModelState);
            Logger.Warn("warn");
            Logger.Info("info");
            Logger.Trace("trace");
            Logger.Error("error");
            Logger.Debug("debug");

            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var result = PersonService.GetPerson(id, ModelState);

            return "value";
        }

        // POST api/<PersonsController>
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {

            var result = PersonService.SavePerson(person, ModelState);
            if (ModelState.ErrorCount > 0)
                return BadRequest(ModelState);

            return Ok(result);
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            try
            {
                throw new Exception("Some error happened during PUT operation");
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                ModelState.Clear();
                ModelState.AddModelError(ex.GetType().ToString(), ex.ToString());
                return StatusCode(500, ModelState);
            }
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
