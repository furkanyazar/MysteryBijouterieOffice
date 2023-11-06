﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Product_Name_Unique_Index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UK_Products_Name",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 8, 240, 181, 133, 82, 207, 32, 42, 202, 234, 156, 159, 17, 193, 255, 5, 205, 223, 106, 249, 132, 238, 124, 79, 189, 45, 78, 100, 195, 210, 168, 252, 126, 151, 169, 31, 210, 28, 219, 251, 199, 170, 100, 148, 220, 147, 157, 114, 97, 172, 72, 156, 18, 25, 170, 165, 209, 198, 50, 52, 100, 48, 124, 20 }, new byte[] { 224, 230, 233, 236, 167, 246, 114, 77, 34, 20, 78, 0, 211, 238, 12, 254, 181, 34, 5, 157, 249, 36, 158, 119, 237, 194, 210, 35, 33, 216, 142, 25, 30, 200, 106, 169, 216, 16, 147, 105, 3, 218, 88, 81, 216, 134, 204, 243, 25, 14, 234, 187, 13, 150, 250, 202, 222, 229, 90, 165, 62, 188, 79, 72, 225, 186, 105, 247, 63, 185, 74, 36, 136, 30, 196, 72, 59, 228, 194, 250, 125, 9, 83, 197, 101, 102, 55, 77, 102, 191, 20, 76, 150, 56, 171, 87, 232, 164, 37, 148, 23, 222, 100, 191, 237, 201, 107, 211, 160, 50, 39, 19, 74, 28, 228, 173, 170, 57, 153, 141, 100, 19, 147, 196, 151, 50, 71, 253 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 81, 87, 52, 219, 64, 38, 214, 158, 93, 79, 50, 247, 238, 100, 5, 158, 167, 63, 117, 143, 183, 22, 66, 34, 38, 198, 205, 180, 164, 71, 85, 244, 174, 217, 32, 72, 16, 221, 227, 88, 242, 249, 170, 66, 162, 114, 111, 216, 204, 226, 114, 7, 117, 32, 55, 90, 192, 222, 203, 74, 103, 43, 79, 251 }, new byte[] { 147, 182, 225, 222, 135, 84, 192, 4, 187, 145, 56, 152, 22, 195, 69, 190, 218, 12, 155, 221, 50, 161, 49, 240, 162, 48, 159, 37, 126, 219, 73, 137, 229, 253, 243, 159, 6, 193, 121, 192, 35, 11, 162, 187, 85, 118, 157, 166, 170, 17, 225, 119, 166, 173, 5, 142, 157, 147, 236, 174, 27, 220, 216, 90, 120, 121, 123, 164, 169, 139, 182, 132, 122, 22, 160, 34, 204, 137, 104, 38, 240, 79, 26, 201, 230, 255, 217, 103, 86, 220, 233, 88, 24, 39, 162, 241, 204, 181, 194, 5, 57, 40, 11, 223, 114, 58, 216, 86, 157, 165, 61, 41, 178, 247, 100, 222, 238, 235, 35, 24, 95, 177, 28, 253, 95, 226, 231, 133 } });

            migrationBuilder.CreateIndex(
                name: "UK_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);
        }
    }
}