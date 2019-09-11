using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoNadd3;
using ProjetoNadd3.Mapeamento;

namespace ProjetoNadd3.Models
{
    public class ProjetoNadd3Context : DbContext
    {
        public ProjetoNadd3Context (DbContextOptions<ProjetoNadd3Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoNadd3.Area> Area { get; set; }
        public DbSet<ProjetoNadd3.Curso> Curso { get; set; }
        public DbSet<ProjetoNadd3.Perfil> Perfil { get; set; }
        public DbSet<ProjetoNadd3.Usuario> Usuario { get; set; }
        public DbSet<ProjetoNadd3.Professor> Professor { get; set; }
        public DbSet<ProjetoNadd3.Prova> Prova { get; set; }
        public DbSet<ProjetoNadd3.Avaliacao> Avaliacao { get; set; }
        public DbSet<ProjetoNadd3.Disciplina> Disciplina { get; set; }
        //public DbSet<ProjetoNadd3.DisciplinasProfessor> DisciplinasProfessor { get; set; }
        //public DbSet<DisciplinasProfessor> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new AreaMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new ProvaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            //modelBuilder.Entity<DisciplinasProfessor>()
            //    .HasKey(o => new { o.DisciplinasId, o.ProfessoresId });

            //Relacionamento Curso-->Area
            modelBuilder.Entity<Area>()
                .HasMany(c => c.Cursos)
                .WithOne(e => e.Areas);

            //Relacionamento Disciplina-->Curso
            modelBuilder.Entity<Curso>()
                .HasMany(c => c.Disciplinas)
                .WithOne(e => e.Cursos);

            //Relacionamento Usuario-->Perfil
            modelBuilder.Entity<Perfil>()
                .HasMany(c => c.Usuarios)
                .WithOne(e => e.Perfis);

            //Relacionamento Professor-->Disciplina
            modelBuilder.Entity<Professor>()
                .HasMany(c => c.Disciplinas)
                .WithOne(e => e.Professores);

            //Relacionamento Prova-->Disciplina
            modelBuilder.Entity<Disciplina>()
                .HasMany(c => c.Provas)
                .WithOne(e => e.Disciplinas);

            //Relacionamento Prova-->Avaliação
            modelBuilder.Entity<Prova>()
                .HasMany(c => c.Avaliacoes)
                .WithOne(e => e.Provas);

            //Relacionamento Perfil-->Usuario
            modelBuilder.Entity<Perfil>()
                .HasMany(c => c.Usuarios)
                .WithOne(e => e.Perfis);

            //modelBuilder.Entity<DisciplinasProfessor>()
            //    .HasKey(bc => new { bc.DisciplinasId, bc.ProfessoresId });
            //modelBuilder.Entity<DisciplinasProfessor>()
            //    .HasOne(bc => bc.Disciplinas)
            //    .WithMany(b => b.DisciplinasProfessores)
            //    .HasForeignKey(bc => bc.DisciplinasId);
            //modelBuilder.Entity<DisciplinasProfessor>()
            //    .HasOne(bc => bc.Professores)
            //    .WithMany(c => c.DisciplinasProfessores)
            //    .HasForeignKey(bc => bc.ProfessoresId);


            //Relacionamento Prova-->Avaliacao
            //modelBuilder.Entity<Prova>()
            //    .HasOne(a => a.Avaliacoes)
            //    .WithOne(b => b.p)
            //    .HasForeignKey<Avaliacao>(b => b.ProvasId);
            //modelBuilder.Entity<Prova>().ToTable("Prova");
            //modelBuilder.Entity<Avaliacao>().ToTable("Avaliacao");

        }

    }
}
