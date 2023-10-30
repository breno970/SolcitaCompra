using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;

namespace SolicitaCompra.Repositories
{
    public class RepositoryControleProduto : RepositoryBase<ControleProduto>, IRepositoryControleProduto
    {
        public RepositoryControleProduto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}