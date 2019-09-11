using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class ProvaMap : IEntityTypeConfiguration<Prova>
    {

        public void Configure(EntityTypeBuilder<Prova> builder)
        {
               
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Prova_Equilibrio_Questao).IsRequired();
            builder.Property(d => d.Prova_Qnt_Questao).IsRequired();
            builder.Property(d => d.Prova_Ref_Bibliografica).IsRequired();
            builder.Property(d => d.Prova_Valor_Explicito).IsRequired();
            builder.Property(d => d.Prova_Valor_Prova).IsRequired();

            //.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasPrincipalKey(f => f.DisciplinasId);
            //builder.HasOne(tc => tc.DisciplinasProfessores).WithMany(tc => tc.Provas).HasForeignKey(f => f.ProfessoresId);
            //builder.HasMany(tc => tc.provas).WithOne(tc => tc.Cursos).OnDelete(DeleteBehavior.Cascade);


            builder.ToTable("Prova");
        }
        
    }
}
