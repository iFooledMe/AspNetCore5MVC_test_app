using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore5MVC_test_app.Migrations
{
    public partial class ExpencesFixedTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sum",
                table: "Expences",
                newName: "Sum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "Expences",
                newName: "sum");
        }
    }
}
