using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
            public void Configure(EntityTypeBuilder<Professor> builder)
            {
                builder.HasKey(d => d.Id);
                builder.Property(d => d.Prof_Nome).IsRequired();
                builder.Property(d => d.Prof_Matricula).IsRequired();
                builder.HasIndex(d => d.Prof_Matricula).IsUnique();



            builder.ToTable("Professor");
            }
        }
}
