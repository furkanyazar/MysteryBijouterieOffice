﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransactionFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxTransactionFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxShippingCost",
                table: "Partners",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxServiceFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxCommissions",
                table: "Partners",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 247, 255, 204, 227, 120, 177, 126, 206, 29, 226, 201, 67, 3, 55, 248, 90, 54, 117, 192, 11, 197, 66, 91, 240, 203, 24, 66, 199, 251, 212, 235, 88, 59, 68, 193, 52, 20, 95, 38, 16, 56, 70, 169, 98, 35, 114, 64, 134, 170, 182, 84, 129, 65, 209, 99, 78, 64, 52, 57, 45, 120, 153, 128 }, new byte[] { 174, 12, 184, 188, 96, 240, 115, 206, 22, 171, 6, 254, 3, 168, 33, 4, 157, 49, 48, 227, 105, 225, 193, 55, 42, 35, 152, 24, 83, 186, 84, 51, 235, 44, 69, 58, 129, 229, 201, 141, 208, 195, 42, 176, 71, 162, 36, 144, 85, 254, 178, 7, 224, 243, 162, 109, 166, 84, 106, 199, 174, 40, 62, 27, 95, 92, 159, 155, 15, 9, 6, 148, 144, 224, 116, 55, 32, 141, 217, 97, 171, 234, 251, 37, 223, 23, 194, 25, 112, 114, 3, 163, 76, 101, 74, 99, 46, 171, 167, 152, 111, 31, 61, 227, 147, 203, 207, 85, 99, 119, 130, 141, 198, 51, 214, 218, 132, 5, 224, 12, 232, 192, 101, 194, 226, 237, 235, 34 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransactionFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxTransactionFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxShippingCost",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxServiceFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasTaxCommissions",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 81, 181, 66, 89, 221, 255, 130, 41, 166, 1, 210, 219, 197, 173, 146, 176, 188, 154, 42, 105, 208, 100, 83, 223, 87, 219, 188, 142, 59, 252, 235, 231, 213, 98, 184, 86, 181, 87, 192, 154, 179, 215, 9, 158, 181, 238, 253, 74, 251, 34, 249, 8, 88, 86, 164, 84, 41, 166, 16, 42, 135, 95, 233 }, new byte[] { 208, 111, 146, 204, 78, 40, 102, 83, 21, 216, 31, 41, 66, 241, 254, 134, 5, 155, 15, 30, 240, 6, 181, 35, 155, 234, 28, 131, 225, 8, 22, 143, 104, 133, 217, 104, 22, 181, 110, 103, 28, 65, 132, 216, 142, 30, 119, 206, 90, 255, 59, 228, 69, 106, 22, 202, 78, 166, 176, 171, 39, 110, 91, 12, 119, 139, 112, 129, 51, 199, 211, 204, 66, 21, 15, 118, 58, 240, 85, 150, 231, 175, 184, 109, 76, 96, 24, 7, 205, 157, 76, 198, 46, 123, 152, 239, 96, 130, 134, 155, 111, 240, 210, 71, 100, 178, 34, 4, 69, 159, 84, 146, 26, 196, 212, 226, 244, 110, 110, 73, 33, 132, 196, 133, 100, 161, 124, 116 } });
        }
    }
}