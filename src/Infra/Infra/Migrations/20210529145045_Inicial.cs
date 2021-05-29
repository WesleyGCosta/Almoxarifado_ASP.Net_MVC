using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Inicial : Migration
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

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    RazaoSocial = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Cnpj = table.Column<string>(type: "Varchar(15)", maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(type: "Varchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Endereco = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Bairro = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Complemento = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FornecedorId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    NomeDoProduto = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal", nullable: false),
                    Categoria = table.Column<string>(maxLength: 15, nullable: false),
                    Cnpj = table.Column<string>(type: "Varchar(15)", maxLength: 15, nullable: false),
                    Descricao = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
