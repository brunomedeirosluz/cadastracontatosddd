namespace ControleDeContatos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoValidacaoNosCampos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contato", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Contato", "Email", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Contato", "Celular", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contato", "Celular", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Contato", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Contato", "Nome", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
