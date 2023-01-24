namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gestran2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DadosCadastroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEndereco = c.Int(nullable: false),
                        NomeFornecedor = c.String(),
                        CnpjFornecedor = c.String(),
                        TelefoneFornecedor = c.String(),
                        EmailFornecedor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DadosCadastroes");
        }
    }
}
