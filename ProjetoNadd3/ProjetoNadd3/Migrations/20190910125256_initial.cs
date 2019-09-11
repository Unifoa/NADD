using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoNadd3.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Perfil_Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prof_Nome = table.Column<string>(nullable: false),
                    Prof_Matricula = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Cur_Nome = table.Column<string>(nullable: false),
                    Cur_Num_Periodos = table.Column<int>(nullable: false),
                    Cur_Ano_Sem = table.Column<int>(nullable: false),
                    AreasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Area_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Usu_Nome = table.Column<string>(nullable: false),
                    Usu_Senha = table.Column<string>(nullable: false),
                    PerfisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfisId",
                        column: x => x.PerfisId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Dis_Nome = table.Column<string>(nullable: false),
                    Dis_Ano = table.Column<int>(nullable: false),
                    Dis_Periodo = table.Column<int>(nullable: false),
                    CursosId = table.Column<int>(nullable: false),
                    ProfessoresId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplina_Curso_CursosId",
                        column: x => x.CursosId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplina_Professor_ProfessoresId",
                        column: x => x.ProfessoresId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prova_Avd = table.Column<int>(nullable: false),
                    Prova_Qnt_Questao = table.Column<int>(nullable: false),
                    Prova_Valor_Explicito = table.Column<int>(nullable: false),
                    Prova_Valor_Prova = table.Column<double>(nullable: false),
                    Prova_Equilibrio_Questao = table.Column<int>(nullable: false),
                    Prova_Ref_Bibliografica = table.Column<int>(nullable: false),
                    DisciplinasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prova", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prova_Disciplina_DisciplinasId",
                        column: x => x.DisciplinasId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ava_Questao = table.Column<int>(nullable: false),
                    Ava_Clareza = table.Column<int>(nullable: false),
                    Ava_Complexibilidade = table.Column<int>(nullable: false),
                    Ava_Contextualizacao = table.Column<int>(nullable: false),
                    Ava_Observacao = table.Column<string>(nullable: true),
                    Ava_Questao_Explicito = table.Column<int>(nullable: false),
                    Ava_Valor_Questao = table.Column<double>(nullable: false),
                    Ava_Mult_Escolha = table.Column<int>(nullable: false),
                    ProvasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Prova_ProvasId",
                        column: x => x.ProvasId,
                        principalTable: "Prova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_Area_Nome",
                table: "Area",
                column: "Area_Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_ProvasId",
                table: "Avaliacao",
                column: "ProvasId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_AreasId",
                table: "Curso",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_CursosId",
                table: "Disciplina",
                column: "CursosId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_ProfessoresId",
                table: "Disciplina",
                column: "ProfessoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_Prof_Matricula",
                table: "Professor",
                column: "Prof_Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prova_DisciplinasId",
                table: "Prova",
                column: "DisciplinasId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfisId",
                table: "Usuario",
                column: "PerfisId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usu_Nome",
                table: "Usuario",
                column: "Usu_Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Prova");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Disciplina");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
