using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {

        public void Configure(EntityTypeBuilder<Area> builder)
        {
               
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Area_Nome).IsRequired();
            builder.HasIndex(d => d.Area_Nome).IsUnique();

         
            //builder.HasMany(tc => tc.Cursos).WithOne(tc => tc.Areas).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Area");
        }
        
    }
}
