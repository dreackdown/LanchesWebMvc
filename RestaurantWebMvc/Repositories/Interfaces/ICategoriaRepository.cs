using RestaurantWebMvc.Models;

namespace RestaurantWebMvc.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
