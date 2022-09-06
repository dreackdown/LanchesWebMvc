using LanchesWebMvc.Models;

namespace LanchesWebMvc.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
