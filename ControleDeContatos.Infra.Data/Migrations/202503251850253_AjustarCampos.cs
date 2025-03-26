namespace ControleDeContatos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustarCampos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contatos", newName: "Contato");
            AlterColumn("dbo.Contato", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Contato", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Contato", "Celular", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contato", "Celular", c => c.String());
            AlterColumn("dbo.Contato", "Email", c => c.String());
            AlterColumn("dbo.Contato", "Nome", c => c.String());
            RenameTable(name: "dbo.Contato", newName: "Contatos");
        }
    }
}
