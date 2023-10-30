using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;

namespace SolicitaCompra.Repositories
{
    public class RepositoryServicoFornecedor : RepositoryBase<Servicos>, IRepositoryServicoFornecedor
    {
        public RepositoryServicoFornecedor(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}