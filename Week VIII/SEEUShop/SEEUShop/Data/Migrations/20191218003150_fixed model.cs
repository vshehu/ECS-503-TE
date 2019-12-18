using Microsoft.EntityFrameworkCore.Migrations;

namespace SEEUShop.Data.Migrations
{
    public partial class fixedmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VATId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_VATId",
                table: "Products",
                column: "VATId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VATs_VATId",
                table: "Products",
                column: "VATId",
                principalTable: "VATs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VATs_VATId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VATId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VATId",
                table: "Products");
        }
    }
}
