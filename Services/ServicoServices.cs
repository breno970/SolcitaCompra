using SolicitaCompra.Interfaces;
using SolicitaCompra.Repositories;

namespace SolicitaCompra.Services
{
    public class ServicoServices
    {
        public RepositoryServicos oRepositoryServicos { get; set; }
       

        public ServicoServices()
        {
            oRepositoryServicos = new RepositoryServicos();
          
        }

    }
}
