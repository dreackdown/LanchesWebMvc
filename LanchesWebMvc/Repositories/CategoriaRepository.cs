using LanchesWebMvc.Context;
using LanchesWebMvc.Models;
using LanchesWebMvc.Repositories.Interfaces;

namespace LanchesWebMvc.Repositories
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
