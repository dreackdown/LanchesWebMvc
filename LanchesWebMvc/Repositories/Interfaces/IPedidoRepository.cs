using LanchesWebMvc.Models;

namespace LanchesWebMvc.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
