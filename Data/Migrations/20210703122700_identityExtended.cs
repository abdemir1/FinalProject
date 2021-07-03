using Microsoft.EntityFrameworkCore.Migrations;

namespace CET322Final.Data.Migrations
{
    public partial class identityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyUserId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MyUserId",
                table: "Recipes",
                column: "MyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_MyUserId",
                table: "Recipes",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_MyUserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_MyUserId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");
        }
    }
}
