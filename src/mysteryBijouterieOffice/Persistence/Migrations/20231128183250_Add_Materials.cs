using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Materials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 107, 2, 237, 165, 9, 131, 218, 101, 210, 107, 67, 59, 179, 106, 159, 39, 225, 40, 69, 63, 73, 232, 55, 141, 5, 37, 99, 215, 85, 20, 23, 8, 214, 209, 13, 84, 107, 38, 242, 177, 197, 157, 108, 196, 142, 87, 75, 20, 18, 191, 21, 187, 134, 204, 191, 83, 143, 232, 101, 56, 228, 182, 59 }, new byte[] { 138, 53, 58, 240, 111, 90, 53, 32, 107, 189, 249, 247, 108, 246, 171, 99, 122, 10, 91, 163, 232, 208, 117, 172, 18, 2, 77, 54, 186, 162, 249, 138, 177, 189, 36, 152, 23, 127, 252, 137, 62, 72, 156, 136, 88, 14, 138, 175, 248, 158, 211, 133, 218, 244, 220, 112, 180, 68, 194, 108, 48, 241, 12, 68, 188, 60, 40, 226, 176, 242, 245, 206, 228, 104, 199, 127, 34, 201, 236, 248, 79, 6, 94, 49, 17, 94, 111, 130, 205, 49, 109, 240, 112, 210, 209, 99, 240, 75, 208, 214, 217, 175, 29, 151, 114, 116, 226, 127, 203, 138, 142, 212, 138, 92, 180, 107, 55, 172, 100, 29, 248, 170, 24, 69, 123, 234, 43, 112 } });

            migrationBuilder.CreateIndex(
                name: "UK_Materials_Name",
                table: "Materials",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_MaterialId",
                table: "ProductMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "UK_ProductMaterials_ProductId_MaterialId",
                table: "ProductMaterials",
                columns: new[] { "ProductId", "MaterialId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 200, 208, 107, 247, 49, 38, 250, 65, 38, 85, 95, 183, 172, 72, 67, 253, 43, 230, 226, 73, 37, 24, 12, 17, 32, 7, 179, 57, 195, 144, 130, 166, 128, 213, 89, 251, 97, 141, 198, 139, 189, 94, 222, 2, 6, 12, 172, 143, 155, 142, 74, 34, 120, 22, 26, 47, 104, 211, 31, 65, 57, 177, 138 }, new byte[] { 97, 8, 221, 238, 165, 153, 18, 60, 122, 68, 222, 175, 234, 221, 195, 190, 191, 133, 15, 251, 123, 11, 150, 179, 254, 179, 155, 144, 135, 199, 220, 190, 11, 69, 243, 149, 163, 177, 233, 244, 251, 12, 160, 183, 124, 245, 88, 53, 60, 169, 102, 83, 252, 65, 194, 174, 249, 83, 214, 108, 150, 241, 108, 231, 209, 255, 199, 135, 237, 187, 15, 103, 75, 159, 47, 9, 60, 50, 65, 56, 95, 198, 6, 226, 189, 141, 50, 168, 200, 155, 6, 77, 209, 121, 186, 91, 253, 73, 231, 48, 111, 161, 180, 58, 1, 83, 43, 142, 113, 192, 38, 52, 139, 131, 120, 130, 14, 183, 116, 59, 42, 236, 131, 221, 181, 229, 107, 92 } });
        }
    }
}
