using RestaurantWebMvc.Models;

namespace RestaurantWebMvc.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
