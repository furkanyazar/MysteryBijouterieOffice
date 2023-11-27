﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Remove_DefaultValue_Of_ModelNumber_On_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 249, 151, 154, 149, 181, 158, 207, 24, 10, 57, 34, 122, 72, 17, 171, 192, 66, 90, 179, 24, 10, 237, 23, 119, 193, 41, 17, 139, 69, 0, 2, 236, 254, 248, 137, 123, 89, 63, 235, 145, 202, 194, 115, 94, 67, 21, 225, 44, 222, 38, 215, 86, 94, 147, 78, 222, 6, 185, 178, 98, 104, 204, 255, 55 }, new byte[] { 113, 209, 57, 51, 42, 83, 247, 218, 241, 193, 44, 83, 147, 235, 59, 36, 120, 41, 202, 159, 147, 54, 149, 177, 45, 104, 61, 65, 78, 158, 239, 166, 15, 156, 214, 199, 66, 63, 159, 125, 67, 120, 219, 138, 145, 68, 209, 48, 254, 42, 30, 210, 237, 148, 181, 184, 51, 45, 35, 225, 24, 217, 31, 4, 126, 53, 21, 83, 82, 199, 158, 110, 225, 136, 135, 165, 136, 171, 37, 63, 66, 110, 221, 46, 137, 146, 154, 166, 191, 85, 88, 143, 240, 155, 157, 191, 154, 245, 105, 194, 103, 30, 142, 1, 249, 226, 54, 69, 19, 22, 251, 216, 193, 69, 16, 162, 162, 151, 201, 246, 163, 26, 3, 7, 195, 127, 164, 23 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 121, 172, 22, 229, 110, 185, 135, 65, 204, 195, 234, 39, 121, 179, 208, 169, 198, 140, 199, 245, 255, 199, 134, 140, 122, 27, 225, 105, 248, 135, 124, 96, 132, 127, 242, 126, 44, 209, 214, 14, 61, 139, 208, 137, 49, 23, 7, 106, 40, 143, 212, 70, 29, 36, 21, 250, 214, 39, 224, 195, 144, 119, 75 }, new byte[] { 172, 84, 50, 167, 74, 180, 217, 83, 78, 139, 168, 57, 144, 221, 138, 230, 21, 193, 95, 178, 16, 102, 162, 54, 160, 104, 168, 216, 190, 204, 63, 180, 158, 75, 211, 180, 145, 186, 68, 95, 84, 255, 222, 79, 41, 28, 211, 201, 183, 20, 69, 43, 213, 190, 133, 219, 98, 246, 254, 224, 36, 212, 187, 84, 21, 94, 134, 92, 151, 33, 167, 163, 71, 249, 124, 203, 157, 170, 42, 98, 52, 214, 90, 115, 65, 163, 177, 193, 130, 18, 230, 160, 42, 134, 245, 98, 143, 144, 132, 124, 51, 160, 128, 227, 65, 228, 245, 185, 152, 183, 6, 234, 131, 213, 102, 36, 118, 199, 226, 87, 83, 236, 249, 143, 206, 167, 97, 233 } });
        }
    }
}