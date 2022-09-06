using LanchesWebMvc.Models;

namespace LanchesWebMvc.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
