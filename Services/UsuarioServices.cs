using SolicitaCompra.Interfaces;
using SolicitaCompra.Repositories;

namespace SolicitaCompra.Services
{
    public class UsuarioServices
    {
        public RepositoryUsuarios oRepositoryUsuarios { get; set; }
       

        public UsuarioServices()
        {
            oRepositoryUsuarios = new RepositoryUsuarios();
          
        }

    }
}
