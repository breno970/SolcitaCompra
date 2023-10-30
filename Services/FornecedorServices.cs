using SolicitaCompra.Interfaces;
using SolicitaCompra.Repositories;

namespace SolicitaCompra.Services
{
    public class FornecedorServices
    {
        public RepositoryFornecedor oRepositoryFornecedor { get; set; }
       

        public FornecedorServices()
        {
            oRepositoryFornecedor = new RepositoryFornecedor();
          
        }

    }
}
