using Microsoft.EntityFrameworkCore.Migrations;

namespace CetTodoWeb.Data.Migrations
{
    public partial class idenetityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CetUserId",
                table: "TodoItems",
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
                name: "IX_TodoItems_CetUserId",
                table: "TodoItems",
                column: "CetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_AspNetUsers_CetUserId",
                table: "TodoItems",
                column: "CetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_AspNetUsers_CetUserId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_CetUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "CetUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");
        }
    }
}
