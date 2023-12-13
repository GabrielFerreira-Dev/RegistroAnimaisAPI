using Microsoft.EntityFrameworkCore;
using RegistroAnimaisAPI.Data;
using RegistroAnimaisAPI.Models;

namespace RegistroAnimaisAPI.Services {
    public class AnimalService {
        private readonly AppDbContext _context;

        public AnimalService(AppDbContext context) {
            _context = context;
        }

        public async Task<List<Animal>> ObterTodosAsync() {
            return await _context.Animal.ToListAsync();
        }

        public async Task CadastrarAnimalAsync(Animal animal) {
            await _context.Animal.AddAsync(animal);
            _context.SaveChanges();
        }

        public async Task EditarAnimal(Animal animal) {
            _context.Animal.Update(animal);
            _context.SaveChanges();            
        }

        public async Task ExcluirAnimal(int id) {
            Animal animal = await obterAnimalPorIdAsync(id);
            if (animal == null) {
                throw new Exception("Animal informado não existe na base!");
            }
            _context.Animal.Remove(animal);
            _context.SaveChanges();
        }

        private async Task<Animal> obterAnimalPorIdAsync(int id) {
            return await _context.Animal.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

    }
}
