using LanchesMac.Context;
using LanchesMac.Models;
namespace LanchesMac.Areas.Admin.Services
{
    public class GraficosVendaService
    {
        public AppDbContext _context { get; set; }
        public GraficosVendaService(AppDbContext context)
        {
            _context = context;
        }

        public List<LancheGrafico> GetVendasLanche(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var lanches = from pd in _context.PedidoDetalhes 
            join l in _context.Lanches on pd.LancheId equals l.LancheId 
            where pd.Pedido.PedidoEnviado >= data
            group pd by new {pd.LancheId, l.Nome, pd.Quantidade}
            into g 
            select new
            {
                LancheNome = g.Key.Nome,
                LanchesQuantidade = g.Sum(g => g.Quantidade),
                LanchesValorTotal = g.Sum(g => g.Preco * g.Quantidade)
            };

            var lista = new List<LancheGrafico>();

            foreach(var item in lanches)
            {
                LancheGrafico lanche = new LancheGrafico();
                lanche.LancheNome = item.LancheNome;
                lanche.LanchesQuantidade = item.LanchesQuantidade;
                lanche.LanchesValorTotal = item.LanchesValorTotal;
                lista.Add(lanche);
            }

            return lista;
        }
    }
}
