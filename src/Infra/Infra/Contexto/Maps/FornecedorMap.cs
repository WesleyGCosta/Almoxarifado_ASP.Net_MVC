using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {

            builder.ToTable("Fornecedores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.RazaoSocial).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(15).HasColumnType("Varchar(15)");
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(15).HasColumnType("Varchar(15)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Complemento).HasMaxLength(30).HasColumnType("Varchar(30)");

            builder.HasMany(x => x.Produtos).WithOne(x => x.Fornecedor);
        }
    }
}
