using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.Infra.Data.EntityConfig;

namespace ControleDeContatos.Infra.Data.Context
{
    public class ControleDeContatoContext : DbContext
    {
        public ControleDeContatoContext() : base("DataBaseContatos")
        {

        }

       public DbSet<Contato> Contatos { get; set; }


       // Definindo algumas configuracoes para o meu BD
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           modelBuilder.Properties()
               .Where(p => p.Name == p.ReflectedType.Name + "Id")
               .Configure(p => p.IsKey());

           modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

           modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

           modelBuilder.Configurations.Add(new ContatoConfiguration());
        }
    }
}