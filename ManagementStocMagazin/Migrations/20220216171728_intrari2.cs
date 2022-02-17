using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementStocMagazin.Migrations
{
    public partial class intrari2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantitate",
                table: "Intrari",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cantitate",
                table: "Iesire",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "CatalogProduse",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "CatalogProduse",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantitate",
                table: "Intrari");

            migrationBuilder.DropColumn(
                name: "Cantitate",
                table: "Iesire");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "CatalogProduse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "CatalogProduse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
