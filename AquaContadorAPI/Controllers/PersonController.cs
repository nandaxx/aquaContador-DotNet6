using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Interfaces;

namespace AquaContadorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService ?? throw new ArgumentNullException(nameof(personService));
        }

        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            var response = await _personService.FindAll();
           return Ok(response);
           

        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> FindById(int id)
        {
            var response = await _personService.FindById(id);
          return Ok(response);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PersonDTO dto)
        {
            var response = await _personService.Create(dto);
           return StatusCode(201);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PersonDTO dto)
        {
            var response = await _personService.Update(dto);
          return Ok(response);
            
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _personService.Delete(id);
        return Ok(response);

        }
    }
}
