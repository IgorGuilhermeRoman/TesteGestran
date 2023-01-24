using Domain.Entidades;
using Domain.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infraestrutura
{
    public class DataContext : DbContext
    {
        public DataContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gestran;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }

       // public DbSet<DadosCadastro> Fornecedores { get; set; }

        public DbSet<DadosCadastroEndereco> DadosCadastroEndereco { get; set; }
        public DbSet<DadosCadastro> DadosCadastro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DadosCadastroEnderecoMap());

            modelBuilder.Configurations.Add(new DadosCadastroMap());
        }
    }
}

