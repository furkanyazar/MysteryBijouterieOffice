﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Category_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 81, 87, 52, 219, 64, 38, 214, 158, 93, 79, 50, 247, 238, 100, 5, 158, 167, 63, 117, 143, 183, 22, 66, 34, 38, 198, 205, 180, 164, 71, 85, 244, 174, 217, 32, 72, 16, 221, 227, 88, 242, 249, 170, 66, 162, 114, 111, 216, 204, 226, 114, 7, 117, 32, 55, 90, 192, 222, 203, 74, 103, 43, 79, 251 }, new byte[] { 147, 182, 225, 222, 135, 84, 192, 4, 187, 145, 56, 152, 22, 195, 69, 190, 218, 12, 155, 221, 50, 161, 49, 240, 162, 48, 159, 37, 126, 219, 73, 137, 229, 253, 243, 159, 6, 193, 121, 192, 35, 11, 162, 187, 85, 118, 157, 166, 170, 17, 225, 119, 166, 173, 5, 142, 157, 147, 236, 174, 27, 220, 216, 90, 120, 121, 123, 164, 169, 139, 182, 132, 122, 22, 160, 34, 204, 137, 104, 38, 240, 79, 26, 201, 230, 255, 217, 103, 86, 220, 233, 88, 24, 39, 162, 241, 204, 181, 194, 5, 57, 40, 11, 223, 114, 58, 216, 86, 157, 165, 61, 41, 178, 247, 100, 222, 238, 235, 35, 24, 95, 177, 28, 253, 95, 226, 231, 133 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 180, 195, 24, 217, 84, 36, 97, 66, 212, 48, 58, 105, 35, 228, 216, 84, 250, 161, 239, 159, 129, 173, 243, 187, 1, 175, 250, 91, 57, 226, 252, 171, 72, 199, 143, 165, 151, 169, 48, 240, 188, 99, 88, 181, 3, 236, 130, 148, 24, 113, 122, 218, 113, 142, 3, 7, 25, 177, 241, 186, 38, 113, 187 }, new byte[] { 120, 202, 49, 177, 24, 152, 208, 98, 151, 106, 116, 5, 235, 214, 89, 85, 7, 171, 79, 241, 89, 55, 240, 44, 196, 174, 176, 37, 42, 150, 30, 239, 55, 67, 105, 3, 246, 94, 91, 175, 19, 118, 91, 177, 146, 54, 127, 75, 202, 102, 174, 47, 94, 88, 211, 100, 126, 27, 134, 240, 131, 198, 164, 142, 221, 225, 191, 77, 37, 222, 42, 125, 205, 146, 43, 179, 75, 139, 160, 185, 11, 244, 3, 158, 250, 34, 202, 250, 227, 210, 214, 186, 174, 12, 201, 182, 92, 227, 208, 217, 218, 169, 246, 161, 201, 149, 124, 156, 254, 51, 5, 131, 210, 63, 228, 251, 165, 0, 96, 42, 4, 33, 174, 62, 81, 76, 195, 162 } });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "UK_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}