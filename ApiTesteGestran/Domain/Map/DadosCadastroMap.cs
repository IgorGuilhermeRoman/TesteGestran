using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Map
{
    public class DadosCadastroMap : EntityTypeConfiguration<DadosCadastro>
    {
        public DadosCadastroMap()
        {
            ToTable("DadosCadastro");
            HasKey(x => x.Id);

            Property(x => x.Id)
              .IsRequired()
              .HasColumnType("int");

            Property(x => x.IdEndereco)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.NomeFornecedor)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            Property(x => x.CnpjFornecedor)
                 .IsRequired()
                 .HasColumnType("varchar")
                 .HasMaxLength(150);

            Property(x => x.TelefoneFornecedor)
                 .IsRequired()
                 .HasColumnType("varchar")
                 .HasMaxLength(12);

            Property(x => x.EmailFornecedor)
                 .IsRequired()
                  .HasColumnType("varchar")
                  .HasMaxLength(150);
        }
    }
}
