
using ControleDeContatos.Application.Interface;
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.Domain.Interfaces.Services;

namespace ControleDeContatos.Application
{
    public class ContatoAppService : AppServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoService _contatoService;
        public ContatoAppService(IContatoService contatoService) : base(contatoService)
        {
            _contatoService = contatoService;
        }
    }
}
