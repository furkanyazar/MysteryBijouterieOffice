﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_LowerLimit_And_Priority_To_Discount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountLowerLimit",
                table: "Discounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 25, 163, 213, 238, 1, 237, 99, 57, 135, 98, 144, 196, 33, 34, 118, 158, 64, 63, 221, 94, 248, 246, 164, 135, 239, 21, 254, 54, 193, 230, 196, 205, 25, 31, 102, 227, 1, 49, 216, 51, 215, 30, 225, 137, 240, 137, 190, 35, 12, 226, 97, 88, 250, 75, 46, 63, 55, 101, 219, 85, 44, 117, 157, 253 }, new byte[] { 52, 132, 143, 173, 118, 19, 93, 152, 183, 76, 197, 46, 206, 200, 191, 141, 17, 159, 188, 150, 199, 11, 1, 137, 15, 227, 62, 95, 176, 162, 120, 97, 12, 250, 192, 148, 114, 116, 244, 150, 45, 39, 60, 184, 217, 162, 99, 31, 30, 125, 191, 33, 80, 57, 55, 240, 115, 32, 81, 187, 40, 162, 21, 199, 33, 61, 96, 63, 111, 123, 252, 6, 118, 128, 5, 131, 88, 37, 2, 238, 10, 242, 120, 243, 157, 64, 115, 246, 114, 181, 159, 238, 19, 108, 94, 152, 198, 166, 212, 99, 195, 186, 203, 141, 113, 55, 252, 66, 52, 73, 35, 117, 132, 13, 117, 8, 51, 232, 159, 97, 26, 187, 195, 24, 74, 30, 123, 225 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountLowerLimit",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Discounts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 6, 177, 5, 91, 127, 64, 249, 44, 85, 38, 178, 28, 213, 35, 239, 65, 81, 3, 241, 113, 125, 8, 112, 125, 176, 33, 39, 56, 93, 49, 32, 159, 71, 148, 175, 139, 244, 87, 247, 178, 103, 120, 235, 9, 20, 180, 84, 249, 180, 39, 25, 32, 209, 108, 235, 161, 138, 132, 170, 19, 208, 48, 180 }, new byte[] { 88, 111, 56, 2, 255, 178, 180, 27, 140, 239, 216, 141, 225, 216, 126, 195, 218, 97, 105, 218, 31, 105, 192, 208, 154, 46, 33, 52, 212, 241, 69, 197, 79, 196, 23, 218, 240, 75, 142, 71, 220, 233, 96, 54, 122, 160, 220, 62, 60, 251, 108, 161, 228, 46, 214, 206, 206, 129, 73, 144, 28, 123, 153, 87, 162, 174, 106, 243, 33, 17, 248, 19, 131, 108, 50, 45, 52, 5, 188, 152, 63, 126, 180, 75, 240, 92, 46, 205, 173, 31, 209, 5, 238, 112, 157, 59, 122, 127, 148, 108, 45, 194, 166, 23, 65, 252, 56, 87, 151, 29, 207, 102, 42, 87, 198, 81, 17, 15, 98, 157, 54, 19, 160, 205, 124, 71, 158, 33 } });
        }
    }
}
