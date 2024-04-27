using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsClasification.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "news",
                newName: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_news_Category_Id",
                table: "news",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_news_categories_Category_Id",
                table: "news",
                column: "Category_Id",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_categories_Category_Id",
                table: "news");

            migrationBuilder.DropIndex(
                name: "IX_news_Category_Id",
                table: "news");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "news",
                newName: "Category");
        }
    }
}
