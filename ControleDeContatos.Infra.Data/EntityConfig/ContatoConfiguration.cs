using System.Data.Entity.ModelConfiguration;
using ControleDeContatos.Domain.Entities;

namespace ControleDeContatos.Infra.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome).IsRequired().HasMaxLength(150);

            Property(c => c.Email).IsRequired().HasMaxLength(150);

            Property(c => c.Celular).IsRequired().HasMaxLength(100);
        }
    }
}