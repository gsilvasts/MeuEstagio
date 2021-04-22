using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuEstagio.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_VAGAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requisitos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desejaveis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experiencia = table.Column<int>(type: "int", nullable: false),
                    TipoContrato = table.Column<int>(type: "int", nullable: false),
                    PeriodoTrabalho = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCidade = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_VAGAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_VAGAS_TB_CIDADES_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "TB_CIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VAGAS_IdCidade",
                table: "TB_VAGAS",
                column: "IdCidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_VAGAS");

            migrationBuilder.DropTable(
                name: "TB_CIDADES");
        }
    }
}
