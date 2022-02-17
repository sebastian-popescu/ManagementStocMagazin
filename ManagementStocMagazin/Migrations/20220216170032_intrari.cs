using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementStocMagazin.Migrations
{
    public partial class intrari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intrari",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogProduseID = table.Column<int>(nullable: false),
                    Descriere = table.Column<string>(nullable: true),
                    DataIntrarii = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intrari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Intrari_CatalogProduse_CatalogProduseID",
                        column: x => x.CatalogProduseID,
                        principalTable: "CatalogProduse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intrari_CatalogProduseID",
                table: "Intrari",
                column: "CatalogProduseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intrari");
        }
    }
}
