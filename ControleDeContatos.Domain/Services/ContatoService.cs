
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.Domain.Interfaces.Repositories;
using ControleDeContatos.Domain.Interfaces.Services;

namespace ControleDeContatos.Domain.Services
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository) : base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
