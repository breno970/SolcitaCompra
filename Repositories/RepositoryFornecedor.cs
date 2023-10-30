using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;


namespace SolicitaCompra.Repositories
{
    public class RepositoryFornecedor : RepositoryBase<Fornecedores>, IRepositoryFornecedor
    {
        public RepositoryFornecedor(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
