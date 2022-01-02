using Microsoft.EntityFrameworkCore.Migrations;

namespace SD.Migrations
{
    public partial class ProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpriedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductModels_ProductModels_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "ProductModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_ProductModelId",
                table: "ProductModels",
                column: "ProductModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductModels");
        }
    }
}
