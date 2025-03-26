namespace ControleDeContatos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustarNomeTabelaContato : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contatoes", newName: "Contatos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Contatos", newName: "Contatoes");
        }
    }
}
