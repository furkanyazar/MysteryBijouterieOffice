using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Category_And_Partner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPartners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: false),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryPartners_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPartners_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 200, 136, 183, 136, 156, 81, 196, 22, 196, 65, 13, 220, 38, 236, 132, 4, 229, 252, 148, 203, 130, 7, 65, 46, 93, 116, 167, 112, 172, 87, 0, 202, 129, 32, 45, 170, 61, 171, 37, 178, 8, 148, 52, 239, 233, 188, 83, 53, 79, 229, 99, 219, 61, 103, 121, 219, 246, 180, 250, 111, 152, 192, 126 }, new byte[] { 240, 230, 112, 230, 103, 130, 57, 181, 83, 71, 102, 191, 168, 3, 241, 127, 51, 55, 212, 220, 70, 185, 61, 61, 19, 28, 230, 41, 203, 14, 235, 82, 202, 75, 216, 189, 18, 7, 152, 70, 4, 15, 99, 145, 207, 211, 245, 148, 17, 135, 11, 252, 30, 34, 28, 189, 123, 84, 245, 137, 122, 235, 122, 98, 3, 254, 119, 74, 197, 235, 244, 186, 200, 184, 12, 127, 213, 100, 182, 75, 183, 154, 245, 187, 128, 93, 208, 230, 128, 10, 180, 193, 26, 68, 29, 122, 187, 140, 191, 191, 106, 56, 47, 109, 62, 185, 167, 173, 129, 182, 105, 97, 77, 141, 74, 42, 28, 47, 118, 168, 201, 201, 121, 201, 88, 147, 128, 220 } });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "UK_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPartners_PartnerId",
                table: "CategoryPartners",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "UK_CategoryPartners_CategoryId_PartnerId",
                table: "CategoryPartners",
                columns: new[] { "CategoryId", "PartnerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Partners_Name",
                table: "Partners",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CategoryPartners");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModelNumber",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 169, 95, 194, 215, 63, 244, 120, 0, 26, 134, 69, 189, 4, 41, 238, 161, 227, 83, 199, 140, 165, 29, 37, 2, 82, 136, 15, 86, 151, 120, 141, 118, 71, 239, 157, 162, 55, 199, 4, 81, 182, 9, 145, 118, 161, 198, 247, 31, 72, 34, 84, 134, 191, 45, 178, 120, 194, 240, 91, 63, 65, 0, 124 }, new byte[] { 114, 179, 51, 86, 160, 25, 72, 129, 201, 190, 212, 56, 180, 125, 109, 172, 110, 152, 84, 37, 39, 204, 191, 196, 217, 4, 15, 197, 136, 48, 151, 208, 21, 110, 82, 250, 96, 108, 105, 212, 55, 80, 139, 96, 191, 195, 117, 172, 107, 241, 169, 106, 227, 24, 154, 84, 245, 169, 56, 238, 119, 66, 132, 114, 194, 51, 91, 166, 86, 68, 227, 112, 103, 159, 77, 71, 90, 191, 70, 1, 103, 233, 132, 14, 152, 84, 76, 91, 6, 40, 196, 125, 53, 146, 63, 165, 141, 25, 99, 47, 243, 196, 33, 150, 245, 121, 128, 20, 15, 129, 4, 22, 57, 163, 93, 227, 202, 110, 83, 169, 226, 246, 129, 134, 6, 121, 255, 147 } });
        }
    }
}
