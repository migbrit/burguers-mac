using LanchesMac.Models;

namespace LanchesMac.Views.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
