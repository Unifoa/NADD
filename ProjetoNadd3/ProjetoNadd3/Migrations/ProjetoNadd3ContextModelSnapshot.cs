﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Migrations
{
    [DbContext(typeof(ProjetoNadd3Context))]
    partial class ProjetoNadd3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoNadd3.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area_Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Area_Nome")
                        .IsUnique();

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ProjetoNadd3.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Ava_Clareza");

                    b.Property<double>("Ava_Complexibilidade");

                    b.Property<double>("Ava_Contextualizacao");

                    b.Property<int>("Ava_Mult_Escolha");

                    b.Property<string>("Ava_Observacao");

                    b.Property<int>("Ava_Questao");

                    b.Property<int>("Ava_Questao_Explicito");

                    b.Property<int>("Ava_Valor_Questao");

                    b.Property<int>("ProvasId");

                    b.HasKey("Id");

                    b.HasIndex("ProvasId");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("ProjetoNadd3.Curso", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("AreasId");

                    b.Property<int>("Cur_Ano_Sem");

                    b.Property<string>("Cur_Nome")
                        .IsRequired();

                    b.Property<int>("Cur_Num_Periodos");

                    b.HasKey("Id");

                    b.HasIndex("AreasId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ProjetoNadd3.Disciplina", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CursosId");

                    b.Property<int>("Dis_Ano");

                    b.Property<string>("Dis_Nome")
                        .IsRequired();

                    b.Property<int>("Dis_Periodo");

                    b.Property<int>("ProfessoresId");

                    b.HasKey("Id");

                    b.HasIndex("CursosId");

                    b.HasIndex("ProfessoresId");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("ProjetoNadd3.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Perfil_Nome");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("ProjetoNadd3.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Prof_Matricula");

                    b.Property<string>("Prof_Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Prof_Matricula")
                        .IsUnique();

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ProjetoNadd3.Prova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisciplinasId");

                    b.Property<int>("Prova_Avd");

                    b.Property<int>("Prova_Equilibrio_Questao");

                    b.Property<int>("Prova_Qnt_Questao");

                    b.Property<int>("Prova_Ref_Bibliografica");

                    b.Property<int>("Prova_Valor_Explicito");

                    b.Property<double>("Prova_Valor_Prova");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinasId");

                    b.ToTable("Prova");
                });

            modelBuilder.Entity("ProjetoNadd3.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PerfisId");

                    b.Property<string>("Usu_Nome")
                        .IsRequired();

                    b.Property<string>("Usu_Senha")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PerfisId");

                    b.HasIndex("Usu_Nome")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoNadd3.Avaliacao", b =>
                {
                    b.HasOne("ProjetoNadd3.Prova", "Provas")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("ProvasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoNadd3.Curso", b =>
                {
                    b.HasOne("ProjetoNadd3.Area", "Areas")
                        .WithMany("Cursos")
                        .HasForeignKey("AreasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoNadd3.Disciplina", b =>
                {
                    b.HasOne("ProjetoNadd3.Curso", "Cursos")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursosId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoNadd3.Professor", "Professores")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessoresId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoNadd3.Prova", b =>
                {
                    b.HasOne("ProjetoNadd3.Disciplina", "Disciplinas")
                        .WithMany("Provas")
                        .HasForeignKey("DisciplinasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoNadd3.Usuario", b =>
                {
                    b.HasOne("ProjetoNadd3.Perfil", "Perfis")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}