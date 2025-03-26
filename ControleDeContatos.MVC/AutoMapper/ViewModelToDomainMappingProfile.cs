using AutoMapper;
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.MVC.ViewModels;

namespace ControleDeContatos.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Contato, ContatoViewModel>();
        }
    }
}