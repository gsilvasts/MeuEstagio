using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuEstagio.API.Migrations
{
    public partial class retirandoEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experiencia",
                table: "TB_VAGAS");

            migrationBuilder.DropColumn(
                name: "PeriodoTrabalho",
                table: "TB_VAGAS");

            migrationBuilder.DropColumn(
                name: "TipoContrato",
                table: "TB_VAGAS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Experiencia",
                table: "TB_VAGAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeriodoTrabalho",
                table: "TB_VAGAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoContrato",
                table: "TB_VAGAS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
