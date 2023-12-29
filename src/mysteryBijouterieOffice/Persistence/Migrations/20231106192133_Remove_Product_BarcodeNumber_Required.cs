﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Product_BarcodeNumber_Required : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BarcodeNumber",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 169, 95, 194, 215, 63, 244, 120, 0, 26, 134, 69, 189, 4, 41, 238, 161, 227, 83, 199, 140, 165, 29, 37, 2, 82, 136, 15, 86, 151, 120, 141, 118, 71, 239, 157, 162, 55, 199, 4, 81, 182, 9, 145, 118, 161, 198, 247, 31, 72, 34, 84, 134, 191, 45, 178, 120, 194, 240, 91, 63, 65, 0, 124 }, new byte[] { 114, 179, 51, 86, 160, 25, 72, 129, 201, 190, 212, 56, 180, 125, 109, 172, 110, 152, 84, 37, 39, 204, 191, 196, 217, 4, 15, 197, 136, 48, 151, 208, 21, 110, 82, 250, 96, 108, 105, 212, 55, 80, 139, 96, 191, 195, 117, 172, 107, 241, 169, 106, 227, 24, 154, 84, 245, 169, 56, 238, 119, 66, 132, 114, 194, 51, 91, 166, 86, 68, 227, 112, 103, 159, 77, 71, 90, 191, 70, 1, 103, 233, 132, 14, 152, 84, 76, 91, 6, 40, 196, 125, 53, 146, 63, 165, 141, 25, 99, 47, 243, 196, 33, 150, 245, 121, 128, 20, 15, 129, 4, 22, 57, 163, 93, 227, 202, 110, 83, 169, 226, 246, 129, 134, 6, 121, 255, 147 } });

            migrationBuilder.CreateIndex(
                name: "UK_Products_BarcodeNumber",
                table: "Products",
                column: "BarcodeNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UK_Products_BarcodeNumber",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "BarcodeNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 8, 240, 181, 133, 82, 207, 32, 42, 202, 234, 156, 159, 17, 193, 255, 5, 205, 223, 106, 249, 132, 238, 124, 79, 189, 45, 78, 100, 195, 210, 168, 252, 126, 151, 169, 31, 210, 28, 219, 251, 199, 170, 100, 148, 220, 147, 157, 114, 97, 172, 72, 156, 18, 25, 170, 165, 209, 198, 50, 52, 100, 48, 124, 20 }, new byte[] { 224, 230, 233, 236, 167, 246, 114, 77, 34, 20, 78, 0, 211, 238, 12, 254, 181, 34, 5, 157, 249, 36, 158, 119, 237, 194, 210, 35, 33, 216, 142, 25, 30, 200, 106, 169, 216, 16, 147, 105, 3, 218, 88, 81, 216, 134, 204, 243, 25, 14, 234, 187, 13, 150, 250, 202, 222, 229, 90, 165, 62, 188, 79, 72, 225, 186, 105, 247, 63, 185, 74, 36, 136, 30, 196, 72, 59, 228, 194, 250, 125, 9, 83, 197, 101, 102, 55, 77, 102, 191, 20, 76, 150, 56, 171, 87, 232, 164, 37, 148, 23, 222, 100, 191, 237, 201, 107, 211, 160, 50, 39, 19, 74, 28, 228, 173, 170, 57, 153, 141, 100, 19, 147, 196, 151, 50, 71, 253 } });
        }
    }
}
