using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {

        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
               
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Perfil_Nome).IsRequired();
            builder.HasIndex(d => d.Perfil_Nome).IsUnique();

            //.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasPrincipalKey(f => f.DisciplinasId);
            //builder.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasForeignKey(f => f.ProfessoresId);
            //builder.HasMany(tc => tc.provas).WithOne(tc => tc.Cursos).OnDelete(DeleteBehavior.Cascade);


            builder.ToTable("Perfil");
        }
        
    }
}
