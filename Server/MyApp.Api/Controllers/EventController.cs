using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.DTO.ViewModels;
using MyApp.Repo.Interface;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IRepository<EventVM> repository;

        public EventController(IRepository<EventVM> repository)
        {
            this.repository = repository;
        }

        public ActionResult Get()
        {
            var data = repository.GetAll();
            if (data != null)
                return Ok(data);
            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult Get(long id)
        {
            var data = repository.Get(id);
            if (data != null)
                return Ok(data);
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<EventVM>> Post(EventVM obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var data = repository.Add(obj);
            return CreatedAtAction(nameof(Get), new { id = data.ID }, data);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<EventVM>> Put(EventVM obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                var mainData = repository.Get(obj.ID);
                if (mainData == null)
                    return NotFound();
                var data = repository.Update(obj);
                return data;
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var mainData = repository.Get(id);
            if (mainData == null)
                return NotFound();
            var data = repository.Remove(id);
            if (data)
                return NoContent();
            return NotFound();
        }

    }
   
}