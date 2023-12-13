using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroAnimaisAPI.Data;
using RegistroAnimaisAPI.Models;
using RegistroAnimaisAPI.Services;

namespace RegistroAnimaisAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase {
        private readonly AnimalService _animaisService;

        public AnimaisController(AnimalService animalService) {
            _animaisService = animalService;
        }


        [HttpGet("ObterTodos")]
        public async Task<ActionResult<List<Animal>>> ObterTodos() {
            var animais = await _animaisService.ObterTodosAsync();
            return Ok(animais.Count() > 0 ? animais : "Nenhum animal cadastrado!");
        }

        [HttpPost("CadastrarAnimal")]
        public async Task<IActionResult> CadastrarAnimal(Animal animal) {
            var animalCriado = _animaisService.CadastrarAnimalAsync(animal);
            return Ok(animalCriado);
        }

        [HttpDelete("ExcluirAnimal")]
        public async Task<IActionResult> ExcluirAnimal(int idAnimal) {
            await _animaisService.ExcluirAnimal(idAnimal);
            return Ok("Animal excluído com sucesso!");
        }

        [HttpPut("AtualizarAnimal")]
        public async Task<IActionResult> EditarAnimal(Animal animal) {
            var animalEditado = _animaisService.EditarAnimal(animal);
            return Ok(animalEditado);
        }
    }
}
