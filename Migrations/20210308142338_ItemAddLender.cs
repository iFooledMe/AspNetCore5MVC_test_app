using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore5MVC_test_app.Migrations
{
    public partial class ItemAddLender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");
        }
    }
}
