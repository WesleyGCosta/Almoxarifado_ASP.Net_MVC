using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeDoProduto).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Quantidade).IsRequired().HasColumnType("int");
            builder.Property(x => x.Preco).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.Categoria).HasConversion(y => y.ToString(), y => (ECategoria)Enum.Parse(typeof(ECategoria), y)).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(15).HasColumnType("Varchar(15)");
            builder.Property(x => x.Descricao).HasMaxLength(30).HasColumnType("Varchar(30)");


        }
    }
    
}
