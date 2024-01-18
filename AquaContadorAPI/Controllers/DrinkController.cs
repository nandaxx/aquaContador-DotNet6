using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Interfaces;

namespace AquaContadorAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService ?? throw new ArgumentNullException(nameof(drinkService));
        }

        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            var response = await _drinkService.FindAll();
            return Ok(response);


        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> FindById(int id)
        {
            var response = await _drinkService.FindById(id);
            return Ok(response);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] DrinkDTO dto)
        {
            var response = await _drinkService.Create(dto);
            return StatusCode(201);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] DrinkDTO dto)
        {
            var response = await _drinkService.Update(dto);
            return Ok(response);

        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _drinkService.Delete(id);
            return Ok(response);

        }
    }
}
