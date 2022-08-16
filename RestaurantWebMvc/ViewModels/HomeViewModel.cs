using RestaurantWebMvc.Models;

namespace RestaurantWebMvc.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
