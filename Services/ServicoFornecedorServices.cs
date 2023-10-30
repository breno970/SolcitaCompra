using SolicitaCompra.Interfaces;
using SolicitaCompra.Repositories;

namespace SolicitaCompra.Services
{
    public class ServicoFornecedorServices
    {
        public RepositoryVwServicoFornecedor oRepositoryServicoFornecedor { get; set; }
        public RepositoryFornecedor oRepositoryFornecedor { get; set; }
        public RepositoryServicos oRepositoryServicos { get; set; }

        public ServicoFornecedorServices()
        {
            oRepositoryServicoFornecedor = new RepositoryVwServicoFornecedor();
            oRepositoryFornecedor = new RepositoryFornecedor();
            oRepositoryServicos = new RepositoryServicos();
        }

    }
}
