using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAspNetCodeFirst.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(150)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(150)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaID",
                table: "Livro",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Titulo",
                table: "Livro",
                column: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
