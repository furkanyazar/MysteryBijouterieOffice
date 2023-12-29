﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_SalePrice_To_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Products",
                newName: "SalePrice");

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 117, 38, 70, 153, 34, 230, 79, 128, 203, 58, 133, 58, 25, 111, 61, 150, 206, 220, 187, 126, 114, 153, 102, 232, 133, 225, 136, 172, 127, 250, 134, 34, 23, 227, 220, 235, 185, 249, 113, 74, 201, 101, 252, 139, 78, 35, 68, 78, 5, 189, 38, 189, 219, 67, 121, 154, 248, 131, 197, 128, 166, 111, 250, 243 }, new byte[] { 145, 170, 15, 191, 172, 95, 203, 13, 138, 93, 252, 213, 107, 116, 204, 122, 230, 74, 247, 233, 100, 202, 245, 210, 220, 145, 169, 235, 220, 59, 41, 113, 41, 250, 218, 48, 134, 57, 82, 89, 136, 179, 242, 218, 128, 47, 17, 143, 109, 156, 158, 210, 176, 45, 78, 56, 11, 24, 191, 78, 240, 241, 62, 135, 175, 187, 133, 60, 136, 163, 143, 73, 84, 194, 178, 203, 216, 135, 211, 160, 61, 155, 194, 253, 15, 41, 216, 0, 172, 246, 198, 253, 41, 99, 83, 216, 162, 129, 199, 8, 82, 28, 166, 92, 178, 139, 125, 41, 155, 189, 118, 143, 95, 184, 50, 89, 249, 200, 65, 233, 50, 162, 170, 211, 207, 217, 142, 63 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SalePrice",
                table: "Products",
                newName: "UnitPrice");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 37, 102, 203, 144, 188, 211, 136, 164, 101, 44, 30, 240, 229, 77, 169, 15, 122, 82, 61, 21, 138, 35, 209, 160, 105, 194, 120, 49, 246, 235, 26, 44, 69, 11, 20, 238, 57, 153, 92, 116, 18, 197, 49, 174, 38, 112, 34, 173, 114, 214, 121, 42, 171, 29, 2, 33, 200, 113, 69, 207, 25, 30, 116 }, new byte[] { 180, 12, 160, 138, 41, 191, 194, 45, 158, 41, 238, 32, 3, 37, 7, 53, 225, 64, 70, 99, 102, 10, 2, 254, 197, 35, 138, 216, 212, 205, 218, 189, 18, 53, 150, 172, 38, 122, 130, 195, 73, 145, 99, 33, 243, 224, 128, 136, 7, 48, 7, 122, 192, 35, 90, 236, 107, 17, 179, 96, 157, 10, 201, 198, 80, 1, 178, 60, 170, 183, 20, 178, 254, 235, 221, 53, 123, 183, 152, 252, 89, 24, 27, 32, 126, 141, 213, 234, 62, 203, 66, 47, 198, 28, 24, 69, 37, 7, 234, 132, 189, 157, 131, 203, 69, 17, 142, 253, 225, 132, 108, 97, 214, 169, 74, 224, 237, 109, 31, 102, 117, 85, 16, 64, 191, 35, 223, 72 } });
        }
    }
}
