using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LK15.Migrations
{
    /// <inheritdoc />
    public partial class DBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopId);
                });

            migrationBuilder.CreateTable(
                name: "ShopNets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopNets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemShop",
                columns: table => new
                {
                    ItemsItemId = table.Column<int>(type: "int", nullable: false),
                    ShopsShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemShop", x => new { x.ItemsItemId, x.ShopsShopId });
                    table.ForeignKey(
                        name: "FK_ItemShop_Item_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemShop_Shop_ShopsShopId",
                        column: x => x.ShopsShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopShopNet",
                columns: table => new
                {
                    ShopNetsId = table.Column<int>(type: "int", nullable: false),
                    ShopsShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopShopNet", x => new { x.ShopNetsId, x.ShopsShopId });
                    table.ForeignKey(
                        name: "FK_ShopShopNet_ShopNets_ShopNetsId",
                        column: x => x.ShopNetsId,
                        principalTable: "ShopNets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopShopNet_Shop_ShopsShopId",
                        column: x => x.ShopsShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemShop_ShopsShopId",
                table: "ItemShop",
                column: "ShopsShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopShopNet_ShopsShopId",
                table: "ShopShopNet",
                column: "ShopsShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemShop");

            migrationBuilder.DropTable(
                name: "ShopShopNet");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ShopNets");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
