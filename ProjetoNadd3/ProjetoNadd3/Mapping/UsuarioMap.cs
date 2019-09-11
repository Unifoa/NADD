using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
               
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Usu_Nome).IsRequired();
            builder.HasIndex(d => d.Usu_Nome).IsUnique();
            builder.Property(d => d.Usu_Senha).IsRequired();

            //.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasPrincipalKey(f => f.DisciplinasId);
            //builder.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasForeignKey(f => f.ProfessoresId);
            //builder.HasMany(tc => tc.provas).WithOne(tc => tc.Cursos).OnDelete(DeleteBehavior.Cascade);


            builder.ToTable("Usuario");
        }
        
    }
}
