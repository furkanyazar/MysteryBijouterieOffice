﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Discounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Partners_PartnerId",
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
                values: new object[] { new byte[] { 38, 6, 177, 5, 91, 127, 64, 249, 44, 85, 38, 178, 28, 213, 35, 239, 65, 81, 3, 241, 113, 125, 8, 112, 125, 176, 33, 39, 56, 93, 49, 32, 159, 71, 148, 175, 139, 244, 87, 247, 178, 103, 120, 235, 9, 20, 180, 84, 249, 180, 39, 25, 32, 209, 108, 235, 161, 138, 132, 170, 19, 208, 48, 180 }, new byte[] { 88, 111, 56, 2, 255, 178, 180, 27, 140, 239, 216, 141, 225, 216, 126, 195, 218, 97, 105, 218, 31, 105, 192, 208, 154, 46, 33, 52, 212, 241, 69, 197, 79, 196, 23, 218, 240, 75, 142, 71, 220, 233, 96, 54, 122, 160, 220, 62, 60, 251, 108, 161, 228, 46, 214, 206, 206, 129, 73, 144, 28, 123, 153, 87, 162, 174, 106, 243, 33, 17, 248, 19, 131, 108, 50, 45, 52, 5, 188, 152, 63, 126, 180, 75, 240, 92, 46, 205, 173, 31, 209, 5, 238, 112, 157, 59, 122, 127, 148, 108, 45, 194, 166, 23, 65, 252, 56, 87, 151, 29, 207, 102, 42, 87, 198, 81, 17, 15, 98, 157, 54, 19, 160, 205, 124, 71, 158, 33 } });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_PartnerId",
                table: "Discounts",
                column: "PartnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 38, 231, 98, 3, 35, 86, 89, 249, 10, 146, 48, 28, 77, 58, 254, 97, 1, 82, 54, 245, 141, 100, 127, 124, 136, 152, 158, 249, 12, 131, 61, 2, 214, 71, 238, 193, 52, 166, 143, 20, 249, 157, 94, 44, 120, 176, 61, 226, 145, 33, 151, 241, 202, 185, 47, 71, 150, 21, 120, 50, 64, 246, 147 }, new byte[] { 86, 230, 126, 13, 18, 9, 127, 132, 185, 15, 193, 174, 160, 153, 229, 9, 173, 5, 168, 22, 199, 235, 109, 128, 255, 49, 246, 30, 235, 254, 176, 36, 142, 204, 177, 20, 29, 221, 66, 134, 25, 122, 211, 234, 238, 229, 113, 71, 152, 106, 253, 120, 115, 242, 173, 173, 230, 205, 45, 54, 71, 166, 96, 206, 226, 167, 251, 140, 174, 65, 24, 26, 178, 12, 178, 219, 172, 164, 137, 31, 232, 150, 237, 137, 93, 26, 82, 114, 48, 158, 38, 104, 63, 82, 240, 160, 222, 39, 148, 135, 41, 56, 248, 230, 51, 11, 53, 211, 180, 165, 37, 154, 99, 78, 104, 78, 160, 75, 91, 89, 34, 156, 14, 195, 40, 126, 122, 153 } });
        }
    }
}