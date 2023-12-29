using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 38, 231, 98, 3, 35, 86, 89, 249, 10, 146, 48, 28, 77, 58, 254, 97, 1, 82, 54, 245, 141, 100, 127, 124, 136, 152, 158, 249, 12, 131, 61, 2, 214, 71, 238, 193, 52, 166, 143, 20, 249, 157, 94, 44, 120, 176, 61, 226, 145, 33, 151, 241, 202, 185, 47, 71, 150, 21, 120, 50, 64, 246, 147 }, new byte[] { 86, 230, 126, 13, 18, 9, 127, 132, 185, 15, 193, 174, 160, 153, 229, 9, 173, 5, 168, 22, 199, 235, 109, 128, 255, 49, 246, 30, 235, 254, 176, 36, 142, 204, 177, 20, 29, 221, 66, 134, 25, 122, 211, 234, 238, 229, 113, 71, 152, 106, 253, 120, 115, 242, 173, 173, 230, 205, 45, 54, 71, 166, 96, 206, 226, 167, 251, 140, 174, 65, 24, 26, 178, 12, 178, 219, 172, 164, 137, 31, 232, 150, 237, 137, 93, 26, 82, 114, 48, 158, 38, 104, 63, 82, 240, 160, 222, 39, 148, 135, 41, 56, 248, 230, 51, 11, 53, 211, 180, 165, 37, 154, 99, 78, 104, 78, 160, 75, 91, 89, 34, 156, 14, 195, 40, 126, 122, 153 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Products",
                type: "nvarchar(max)",
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
                values: new object[] { new byte[] { 90, 247, 255, 204, 227, 120, 177, 126, 206, 29, 226, 201, 67, 3, 55, 248, 90, 54, 117, 192, 11, 197, 66, 91, 240, 203, 24, 66, 199, 251, 212, 235, 88, 59, 68, 193, 52, 20, 95, 38, 16, 56, 70, 169, 98, 35, 114, 64, 134, 170, 182, 84, 129, 65, 209, 99, 78, 64, 52, 57, 45, 120, 153, 128 }, new byte[] { 174, 12, 184, 188, 96, 240, 115, 206, 22, 171, 6, 254, 3, 168, 33, 4, 157, 49, 48, 227, 105, 225, 193, 55, 42, 35, 152, 24, 83, 186, 84, 51, 235, 44, 69, 58, 129, 229, 201, 141, 208, 195, 42, 176, 71, 162, 36, 144, 85, 254, 178, 7, 224, 243, 162, 109, 166, 84, 106, 199, 174, 40, 62, 27, 95, 92, 159, 155, 15, 9, 6, 148, 144, 224, 116, 55, 32, 141, 217, 97, 171, 234, 251, 37, 223, 23, 194, 25, 112, 114, 3, 163, 76, 101, 74, 99, 46, 171, 167, 152, 111, 31, 61, 227, 147, 203, 207, 85, 99, 119, 130, 141, 198, 51, 214, 218, 132, 5, 224, 12, 232, 192, 101, 194, 226, 237, 235, 34 } });
        }
    }
}
