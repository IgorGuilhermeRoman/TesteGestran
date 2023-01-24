namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gestran3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DadosCadastroes", newName: "DadosCadastro");
            RenameTable(name: "dbo.DadosCadastroEnderecoes", newName: "DadosCadastroEndereco");
            AlterColumn("dbo.DadosCadastro", "NomeFornecedor", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastro", "CnpjFornecedor", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastro", "TelefoneFornecedor", c => c.String(nullable: false, maxLength: 12, unicode: false));
            AlterColumn("dbo.DadosCadastro", "EmailFornecedor", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Cep", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Rua", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Complemento", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Cidade", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Estado", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.DadosCadastroEndereco", "Pais", c => c.String(nullable: false, maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DadosCadastroEndereco", "Pais", c => c.String());
            AlterColumn("dbo.DadosCadastroEndereco", "Estado", c => c.String());
            AlterColumn("dbo.DadosCadastroEndereco", "Cidade", c => c.String());
            AlterColumn("dbo.DadosCadastroEndereco", "Complemento", c => c.String());
            AlterColumn("dbo.DadosCadastroEndereco", "Rua", c => c.String());
            AlterColumn("dbo.DadosCadastroEndereco", "Cep", c => c.String());
            AlterColumn("dbo.DadosCadastro", "EmailFornecedor", c => c.String());
            AlterColumn("dbo.DadosCadastro", "TelefoneFornecedor", c => c.String());
            AlterColumn("dbo.DadosCadastro", "CnpjFornecedor", c => c.String());
            AlterColumn("dbo.DadosCadastro", "NomeFornecedor", c => c.String());
            RenameTable(name: "dbo.DadosCadastroEndereco", newName: "DadosCadastroEnderecoes");
            RenameTable(name: "dbo.DadosCadastro", newName: "DadosCadastroes");
        }
    }
}
