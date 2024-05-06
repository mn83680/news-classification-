using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsClassNet6.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherId",
                table: "news",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher_Id",
                table: "news",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_news_PublisherId",
                table: "news",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_news_AspNetUsers_PublisherId",
                table: "news",
                column: "PublisherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_AspNetUsers_PublisherId",
                table: "news");

            migrationBuilder.DropIndex(
                name: "IX_news_PublisherId",
                table: "news");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "news");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "news");
        }
    }
}
