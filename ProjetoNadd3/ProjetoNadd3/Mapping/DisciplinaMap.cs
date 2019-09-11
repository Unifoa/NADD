using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
    {
            public void Configure(EntityTypeBuilder<Disciplina> builder)
            {
                builder.HasKey(d => d.Id);
                builder.Property(d => d.Dis_Nome).IsRequired();
                builder.Property(d => d.Dis_Ano).IsRequired();
                builder.Property(d => d.Dis_Periodo).IsRequired();


            //builder.HasOne(tc => tc.Cursos).WithMany(tc => tc.Disciplinas).HasForeignKey(f => f.CursosId);
            //    builder.HasMany(s => s.DisciplinasProfessores).WithOne(x => x.Disciplinas);

                builder.ToTable("Disciplina");
            }
        }
}
