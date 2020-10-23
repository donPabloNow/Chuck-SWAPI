using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using Services;

namespace API.Controllers
{
    [Route("[controller]")]
    public class HojaDeTiempoController : Controller
    {
        private readonly IHojaDeTiempoService _hojaDeTiempoService;

        public HojaDeTiempoController(IHojaDeTiempoService hojaDeTiempoService)
        {
            _hojaDeTiempoService = hojaDeTiempoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_hojaDeTiempoService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GeById(int id)
        {
            return Ok(
                _hojaDeTiempoService.GeById(id)
            );
        }

        // POST api/values
        // el FromBody indica que 
        [HttpPost]
        public IActionResult Post([FromBody] HojaDeTiempos model)
        {
            return Ok(
                _hojaDeTiempoService.Add(model)
            );
        }

        // PUT api/values/5
        // El put quiere decir que si el recurso actual no existe lo crea o lo actualiza el recurso está especificado en la URL
        [HttpPut]
        public IActionResult Put([FromBody] HojaDeTiempos model)
        {
            return Ok(
                _hojaDeTiempoService.Update(model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _hojaDeTiempoService.Delete(id)
            );
        }
    }
}