using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Contexto.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnType("Varchar(50)");
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(15).HasColumnType("Varchar(15)");
            builder.Property(x => x.DataDeNascimento).IsRequired().HasColumnType("Date");
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(15).HasColumnType("Varchar(15)");
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(50).HasColumnType("Varchar(50)");
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(20).HasColumnType("Varchar(40)");
            builder.Property(x => x.Sexo).HasConversion(y => y.ToString(), y => (ESexo)Enum.Parse(typeof(ESexo), y)).HasMaxLength(10).IsRequired();

            builder.HasMany(x => x.Produtos).WithOne(x => x.Cliente);
        }
    }
}
