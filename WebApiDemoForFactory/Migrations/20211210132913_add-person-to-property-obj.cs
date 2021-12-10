using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiDemoForFactory.Migrations
{
    public partial class addpersontopropertyobj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StdProperties_PersonId",
                table: "StdProperties",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_StdProperties_Persons_PersonId",
                table: "StdProperties",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StdProperties_Persons_PersonId",
                table: "StdProperties");

            migrationBuilder.DropIndex(
                name: "IX_StdProperties_PersonId",
                table: "StdProperties");
        }
    }
}
