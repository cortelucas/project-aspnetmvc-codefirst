using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAspNetCodeFirst.Models;

namespace ProjectAspNetCodeFirst.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        { 
            builder.ToTable("Livro");

            builder.Property(p => p.ID)
                .ValueGeneratedNever();
            
            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(150)")
                .IsRequired();
            
            builder.Property(p => p.Autor)
                .HasColumnType("varchar(150)")
                .IsRequired();
            
            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)");

            builder.Property(p => p.DataEntrada)
                .HasColumnType("datetime");

            builder.HasIndex(p => p.Titulo)
                .HasDatabaseName("IX_Livro_Titulo");

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Livros)
                .HasForeignKey(p => p.CategoriaID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}