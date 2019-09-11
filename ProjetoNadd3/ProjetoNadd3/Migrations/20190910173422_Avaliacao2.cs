using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoNadd3.Migrations
{
    public partial class Avaliacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ava_Valor_Questao",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Ava_Valor_Questao",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
