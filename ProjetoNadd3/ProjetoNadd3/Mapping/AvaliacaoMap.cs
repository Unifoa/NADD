using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoNadd3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNadd3.Mapeamento
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Ava_Clareza).IsRequired();
            builder.Property(d => d.Ava_Complexibilidade).IsRequired();
            builder.Property(d => d.Ava_Contextualizacao).IsRequired();
            builder.Property(d => d.Ava_Mult_Escolha).IsRequired();
            builder.Property(d => d.Ava_Observacao);
            builder.Property(d => d.Ava_Questao).IsRequired();
            builder.Property(d => d.Ava_Questao_Explicito).IsRequired();
            builder.Property(d => d.Ava_Valor_Questao).IsRequired();

            //builder.HasOne(tc => tc.Disciplinas).WithMany(tc => tc.Avaliacao).HasForeignKey(f => f.DisciplinaId);
            //builder.HasMany(tc => tc.Questoes).WithOne(tc => tc.Avaliacao);

            builder.ToTable("Avaliacao");
        }
    }
}
