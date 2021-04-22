using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuEstagio.API.Migrations
{
    public partial class Refatorando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_VAGAS_TB_CIDADES_IdCidade",
                table: "TB_VAGAS");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TB_VAGAS");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_VAGAS_TB_CIDADES_IdCidade",
                table: "TB_VAGAS",
                column: "IdCidade",
                principalTable: "TB_CIDADES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_VAGAS_TB_CIDADES_IdCidade",
                table: "TB_VAGAS");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "TB_VAGAS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_VAGAS_TB_CIDADES_IdCidade",
                table: "TB_VAGAS",
                column: "IdCidade",
                principalTable: "TB_CIDADES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
