using AutoMapper;
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.MVC.ViewModels;

namespace ControleDeContatos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile

    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ContatoViewModel, Contato>();
        }
    }
}