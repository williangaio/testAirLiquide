using Microsoft.EntityFrameworkCore.Migrations;

namespace AirTest.Api.Migrations
{
    public partial class altercolidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Idade",
                schema: "AirTest",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                schema: "AirTest",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
