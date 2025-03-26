using ControleDeContatos.Domain.Entities;
using ControleDeContatos.Domain.Interfaces.Repositories;

namespace ControleDeContatos.Infra.Data.Repositories
{
    public class ContatoRepository : RepositoryBase<Contato>, IContatoRepository
    {
    }
}
