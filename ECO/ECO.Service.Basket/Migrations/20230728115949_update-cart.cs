using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECO.Service.Basket.Migrations
{
    public partial class updatecart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_BasketId",
                table: "CartItem");

            migrationBuilder.RenameColumn(
                name: "BasketId",
                table: "CartItem",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_BasketId",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "CartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "CartItem");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartItem",
                newName: "BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                newName: "IX_CartItem_BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_BasketId",
                table: "CartItem",
                column: "BasketId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
