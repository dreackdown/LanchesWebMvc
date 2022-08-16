using Microsoft.AspNetCore.Mvc;
using RestaurantWebMvc.Models;
using RestaurantWebMvc.Repositories.Interfaces;
using RestaurantWebMvc.ViewModels;

namespace RestaurantWebMvc.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categorialAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categorialAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                    .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                    .OrderBy(l => l.LancheId);

                categorialAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categorialAtual
            };

            return View(lanchesListViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return View(lanche);
        }
    }
}
