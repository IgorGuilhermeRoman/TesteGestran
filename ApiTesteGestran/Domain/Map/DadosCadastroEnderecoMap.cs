using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Map
{
    public  class DadosCadastroEnderecoMap : EntityTypeConfiguration<DadosCadastroEndereco>
    {
        public DadosCadastroEnderecoMap()
        {
            ToTable("DadosCadastroEndereco");
            HasKey(x => x.Id);

            Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.IdFornecedor)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.Cep)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(150);

            Property(x => x.Rua)
                     .IsRequired()
                     .HasColumnType("varchar")
                     .HasMaxLength(150);

            Property(x => x.Numero)
                     .IsRequired()
                     .HasColumnType("int");

            Property(x => x.Complemento)
                     .IsRequired()
                      .HasColumnType("varchar")
                      .HasMaxLength(150);

            Property(x => x.Cidade)
                 .IsRequired()
                 .HasColumnType("varchar")
                 .HasMaxLength(150);

            Property(x => x.Estado)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            Property(x => x.Pais)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);
        }
    }
}
