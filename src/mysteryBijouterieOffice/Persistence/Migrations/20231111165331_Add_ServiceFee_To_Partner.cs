﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ServiceFee_To_Partner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceFee",
                table: "CategoryPartners");

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 21, 135, 252, 42, 51, 143, 8, 219, 212, 165, 172, 31, 69, 160, 128, 33, 36, 19, 50, 69, 147, 4, 15, 180, 105, 244, 87, 13, 40, 202, 143, 26, 134, 79, 35, 151, 224, 226, 140, 126, 85, 82, 92, 215, 218, 156, 127, 181, 213, 229, 121, 63, 15, 180, 129, 78, 29, 232, 124, 138, 73, 176, 16, 25 }, new byte[] { 201, 242, 59, 154, 173, 131, 149, 166, 150, 189, 40, 4, 83, 209, 66, 34, 13, 84, 204, 224, 105, 170, 1, 0, 246, 172, 17, 63, 97, 207, 27, 21, 123, 76, 255, 58, 18, 139, 219, 118, 201, 45, 157, 101, 110, 164, 50, 179, 25, 3, 54, 119, 125, 86, 107, 39, 135, 227, 31, 78, 3, 134, 72, 177, 94, 13, 9, 85, 210, 136, 79, 1, 206, 135, 114, 254, 120, 120, 100, 216, 75, 209, 97, 61, 115, 200, 163, 0, 96, 241, 176, 15, 214, 224, 47, 232, 175, 166, 64, 179, 224, 0, 245, 115, 72, 75, 32, 134, 111, 137, 223, 184, 223, 84, 125, 98, 183, 199, 78, 26, 176, 234, 70, 30, 204, 186, 208, 28 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceFee",
                table: "Partners");

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceFee",
                table: "CategoryPartners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 246, 115, 202, 170, 224, 52, 67, 210, 107, 90, 178, 108, 149, 5, 174, 203, 155, 153, 102, 103, 43, 171, 240, 250, 185, 88, 55, 8, 177, 1, 200, 241, 123, 122, 86, 85, 191, 118, 71, 48, 85, 106, 222, 149, 217, 147, 16, 194, 39, 60, 213, 146, 142, 237, 8, 93, 117, 36, 48, 113, 9, 17, 47 }, new byte[] { 40, 251, 168, 213, 0, 148, 25, 117, 60, 153, 16, 81, 255, 194, 173, 163, 49, 174, 255, 35, 54, 236, 104, 94, 186, 78, 153, 159, 251, 196, 18, 58, 19, 222, 4, 217, 180, 190, 44, 189, 44, 235, 19, 80, 128, 225, 254, 237, 94, 39, 112, 199, 43, 28, 103, 184, 162, 226, 158, 243, 136, 135, 193, 99, 161, 189, 39, 66, 126, 55, 112, 24, 22, 82, 202, 27, 3, 100, 107, 190, 57, 104, 14, 116, 60, 150, 14, 89, 13, 187, 226, 239, 192, 135, 0, 65, 72, 37, 133, 229, 244, 238, 162, 9, 71, 244, 214, 210, 172, 121, 255, 53, 235, 173, 162, 11, 194, 30, 203, 128, 77, 16, 148, 213, 143, 83, 120, 236 } });
        }
    }
}