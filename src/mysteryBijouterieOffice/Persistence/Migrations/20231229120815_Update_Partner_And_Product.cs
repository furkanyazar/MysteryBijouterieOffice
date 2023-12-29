﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Partner_And_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HasFirstScale",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasSecondScale",
                table: "Partners");

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasShippingScale",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTaxCommissions",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTaxServiceFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTaxShippingCost",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTaxTransactionFee",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "TransactionFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 81, 181, 66, 89, 221, 255, 130, 41, 166, 1, 210, 219, 197, 173, 146, 176, 188, 154, 42, 105, 208, 100, 83, 223, 87, 219, 188, 142, 59, 252, 235, 231, 213, 98, 184, 86, 181, 87, 192, 154, 179, 215, 9, 158, 181, 238, 253, 74, 251, 34, 249, 8, 88, 86, 164, 84, 41, 166, 16, 42, 135, 95, 233 }, new byte[] { 208, 111, 146, 204, 78, 40, 102, 83, 21, 216, 31, 41, 66, 241, 254, 134, 5, 155, 15, 30, 240, 6, 181, 35, 155, 234, 28, 131, 225, 8, 22, 143, 104, 133, 217, 104, 22, 181, 110, 103, 28, 65, 132, 216, 142, 30, 119, 206, 90, 255, 59, 228, 69, 106, 22, 202, 78, 166, 176, 171, 39, 110, 91, 12, 119, 139, 112, 129, 51, 199, 211, 204, 66, 21, 15, 118, 58, 240, 85, 150, 231, 175, 184, 109, 76, 96, 24, 7, 205, 157, 76, 198, 46, 123, 152, 239, 96, 130, 134, 155, 111, 240, 210, 71, 100, 178, 34, 4, 69, 159, 84, 146, 26, 196, 212, 226, 244, 110, 110, 73, 33, 132, 196, 133, 100, 161, 124, 116 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitsInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HasShippingScale",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasTaxCommissions",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasTaxServiceFee",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasTaxShippingCost",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasTaxTransactionFee",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "TransactionFee",
                table: "Partners");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasFirstScale",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasSecondScale",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 107, 2, 237, 165, 9, 131, 218, 101, 210, 107, 67, 59, 179, 106, 159, 39, 225, 40, 69, 63, 73, 232, 55, 141, 5, 37, 99, 215, 85, 20, 23, 8, 214, 209, 13, 84, 107, 38, 242, 177, 197, 157, 108, 196, 142, 87, 75, 20, 18, 191, 21, 187, 134, 204, 191, 83, 143, 232, 101, 56, 228, 182, 59 }, new byte[] { 138, 53, 58, 240, 111, 90, 53, 32, 107, 189, 249, 247, 108, 246, 171, 99, 122, 10, 91, 163, 232, 208, 117, 172, 18, 2, 77, 54, 186, 162, 249, 138, 177, 189, 36, 152, 23, 127, 252, 137, 62, 72, 156, 136, 88, 14, 138, 175, 248, 158, 211, 133, 218, 244, 220, 112, 180, 68, 194, 108, 48, 241, 12, 68, 188, 60, 40, 226, 176, 242, 245, 206, 228, 104, 199, 127, 34, 201, 236, 248, 79, 6, 94, 49, 17, 94, 111, 130, 205, 49, 109, 240, 112, 210, 209, 99, 240, 75, 208, 214, 217, 175, 29, 151, 114, 116, 226, 127, 203, 138, 142, 212, 138, 92, 180, 107, 55, 172, 100, 29, 248, 170, 24, 69, 123, 234, 43, 112 } });
        }
    }
}
