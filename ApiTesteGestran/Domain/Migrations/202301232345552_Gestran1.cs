namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gestran1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DadosCadastroEnderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFornecedor = c.Int(nullable: false),
                        Cep = c.String(),
                        Rua = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DadosCadastroEnderecoes");
        }
    }
}
