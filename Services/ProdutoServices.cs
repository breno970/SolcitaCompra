using SolicitaCompra.Interfaces;
using SolicitaCompra.Repositories;

namespace SolicitaCompra.Services
{
    public class ProdutoServices
    {
        public RepositoryProdutos oRepositoryProdutos { get; set; }
       

        public ProdutoServices()
        {
            oRepositoryProdutos = new RepositoryProdutos();
          
        }

    }
}
