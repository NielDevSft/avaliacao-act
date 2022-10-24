using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Administrativo.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tab_lancamento",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    des_lancamento = table.Column<string>(type: "text", nullable: true),
                    ind_entrada_saida = table.Column<int>(type: "integer", nullable: false),
                    val_lancamento = table.Column<decimal>(type: "numeric", nullable: false),
                    dta_lancamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    dta_create_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    dta_updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_lancamento", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab_lancamento");
        }
    }
}
