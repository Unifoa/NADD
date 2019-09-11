using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoNadd3.Migrations
{
    public partial class Avaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Ava_Contextualizacao",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Ava_Complexibilidade",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Ava_Clareza",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ava_Contextualizacao",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Ava_Complexibilidade",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Ava_Clareza",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
