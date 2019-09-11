using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Cur_Nome).IsRequired();
            builder.Property(d => d.Cur_Ano_Sem).IsRequired();
            builder.Property(d => d.Cur_Num_Periodos).IsRequired();

            //builder.HasOne(tc => tc.Areas).WithMany(tc => tc.Cursos).HasForeignKey(f => f.AreasId);
            //builder.HasMany(tc => tc.Disciplinas).WithOne(tc => tc.Cursos).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Curso");
        }

        
    }
}
