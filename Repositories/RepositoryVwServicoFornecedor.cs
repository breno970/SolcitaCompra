using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;

namespace SolicitaCompra.Repositories
{
    public class RepositoryVwServicoFornecedor : RepositoryBase<VwServicoFornecedor>, IRepositoryVwServicoFornecedor
    {
        public RepositoryVwServicoFornecedor(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}