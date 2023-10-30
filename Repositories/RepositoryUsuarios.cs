using SolicitaCompra.Interfaces;
using SolicitaCompra.Models;

namespace SolicitaCompra.Repositories
{
    public class RepositoryUsuarios : RepositoryBase<Usuarios>, IRepositoryUsuarios
    {
        public RepositoryUsuarios(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}