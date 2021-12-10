using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiDemoForFactory.Migrations
{
    public partial class AddPersonalCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalCode",
                table: "Persons");
        }
    }
}
