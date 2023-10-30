using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;

namespace SolicitaCompra.Repositories
{
    public class RepositoryServicos : RepositoryBase<Servicos>, IRepositoryServicos
    {
        public RepositoryServicos(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}