using RestaurantWebMvc.Context;
using RestaurantWebMvc.Models;
using RestaurantWebMvc.Repositories.Interfaces;

namespace RestaurantWebMvc.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }  
}
