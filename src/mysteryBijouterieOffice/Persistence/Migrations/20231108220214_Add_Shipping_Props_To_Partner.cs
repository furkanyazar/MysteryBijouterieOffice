using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Shipping_Props_To_Partner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FreeShippingLowerLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "HasFreeShipping",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCost",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 199, 14, 211, 27, 34, 106, 73, 107, 40, 50, 23, 36, 252, 193, 88, 154, 188, 43, 244, 236, 2, 20, 87, 175, 116, 60, 241, 249, 86, 24, 120, 23, 62, 8, 136, 26, 140, 255, 40, 143, 40, 242, 254, 243, 91, 147, 200, 25, 49, 41, 84, 193, 36, 193, 15, 105, 94, 198, 83, 98, 182, 119, 229 }, new byte[] { 252, 219, 144, 80, 21, 177, 35, 166, 211, 87, 164, 240, 71, 8, 48, 116, 33, 39, 40, 3, 175, 196, 147, 192, 78, 248, 181, 83, 166, 160, 42, 23, 49, 7, 65, 0, 42, 161, 44, 174, 189, 52, 125, 26, 150, 228, 207, 148, 10, 74, 246, 159, 160, 165, 175, 191, 36, 242, 182, 171, 158, 4, 85, 186, 39, 20, 152, 233, 150, 47, 152, 0, 209, 25, 52, 205, 62, 255, 237, 12, 7, 49, 67, 128, 252, 29, 176, 11, 102, 114, 128, 169, 159, 96, 36, 136, 189, 97, 84, 66, 125, 116, 168, 126, 205, 173, 98, 17, 140, 48, 107, 34, 193, 173, 203, 237, 217, 254, 34, 216, 170, 0, 64, 54, 118, 157, 161, 80 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeShippingLowerLimit",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasFreeShipping",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "Partners");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 249, 151, 154, 149, 181, 158, 207, 24, 10, 57, 34, 122, 72, 17, 171, 192, 66, 90, 179, 24, 10, 237, 23, 119, 193, 41, 17, 139, 69, 0, 2, 236, 254, 248, 137, 123, 89, 63, 235, 145, 202, 194, 115, 94, 67, 21, 225, 44, 222, 38, 215, 86, 94, 147, 78, 222, 6, 185, 178, 98, 104, 204, 255, 55 }, new byte[] { 113, 209, 57, 51, 42, 83, 247, 218, 241, 193, 44, 83, 147, 235, 59, 36, 120, 41, 202, 159, 147, 54, 149, 177, 45, 104, 61, 65, 78, 158, 239, 166, 15, 156, 214, 199, 66, 63, 159, 125, 67, 120, 219, 138, 145, 68, 209, 48, 254, 42, 30, 210, 237, 148, 181, 184, 51, 45, 35, 225, 24, 217, 31, 4, 126, 53, 21, 83, 82, 199, 158, 110, 225, 136, 135, 165, 136, 171, 37, 63, 66, 110, 221, 46, 137, 146, 154, 166, 191, 85, 88, 143, 240, 155, 157, 191, 154, 245, 105, 194, 103, 30, 142, 1, 249, 226, 54, 69, 19, 22, 251, 216, 193, 69, 16, 162, 162, 151, 201, 246, 163, 26, 3, 7, 195, 127, 164, 23 } });
        }
    }
}
