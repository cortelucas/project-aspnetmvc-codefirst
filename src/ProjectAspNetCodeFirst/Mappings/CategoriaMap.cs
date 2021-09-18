using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAspNetCodeFirst.Models;

namespace ProjectAspNetCodeFirst.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        { 
            builder.ToTable("Categoria");
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}