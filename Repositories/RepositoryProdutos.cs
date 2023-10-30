using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;


namespace SolicitaCompra.Repositories
{
    public class RepositoryProdutos : RepositoryBase<Produtos>, IRepositoryProdutos
    {
        public RepositoryProdutos(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}