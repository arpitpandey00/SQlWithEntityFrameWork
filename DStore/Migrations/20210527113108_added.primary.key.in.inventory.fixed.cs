using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DStore.Data.Migrations
{
    public partial class addedprimarykeyininventoryfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Products_ProductId1",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ProductId1",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Inventory_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "Inventory",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Inventory_ProductId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Inventory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId1",
                table: "Inventory",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Products_ProductId1",
                table: "Inventory",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
