using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "Varchar(15)", maxLength: 15, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Telefone = table.Column<string>(type: "Varchar(15)", maxLength: 15, nullable: false),
                    Endereco = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "Varchar(40)", maxLength: 20, nullable: false),
                    Sexo = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
