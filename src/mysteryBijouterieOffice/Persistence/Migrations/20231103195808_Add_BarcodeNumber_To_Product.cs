using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_BarcodeNumber_To_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarcodeNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 180, 195, 24, 217, 84, 36, 97, 66, 212, 48, 58, 105, 35, 228, 216, 84, 250, 161, 239, 159, 129, 173, 243, 187, 1, 175, 250, 91, 57, 226, 252, 171, 72, 199, 143, 165, 151, 169, 48, 240, 188, 99, 88, 181, 3, 236, 130, 148, 24, 113, 122, 218, 113, 142, 3, 7, 25, 177, 241, 186, 38, 113, 187 }, new byte[] { 120, 202, 49, 177, 24, 152, 208, 98, 151, 106, 116, 5, 235, 214, 89, 85, 7, 171, 79, 241, 89, 55, 240, 44, 196, 174, 176, 37, 42, 150, 30, 239, 55, 67, 105, 3, 246, 94, 91, 175, 19, 118, 91, 177, 146, 54, 127, 75, 202, 102, 174, 47, 94, 88, 211, 100, 126, 27, 134, 240, 131, 198, 164, 142, 221, 225, 191, 77, 37, 222, 42, 125, 205, 146, 43, 179, 75, 139, 160, 185, 11, 244, 3, 158, 250, 34, 202, 250, 227, 210, 214, 186, 174, 12, 201, 182, 92, 227, 208, 217, 218, 169, 246, 161, 201, 149, 124, 156, 254, 51, 5, 131, 210, 63, 228, 251, 165, 0, 96, 42, 4, 33, 174, 62, 81, 76, 195, 162 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodeNumber",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 158, 162, 107, 125, 147, 75, 93, 202, 88, 38, 156, 254, 239, 145, 36, 68, 90, 242, 120, 160, 117, 136, 42, 161, 236, 178, 222, 65, 172, 182, 134, 83, 244, 210, 41, 243, 213, 63, 64, 194, 191, 240, 231, 30, 192, 172, 120, 225, 45, 178, 165, 198, 36, 173, 228, 113, 147, 127, 0, 87, 167, 175, 35 }, new byte[] { 149, 216, 245, 155, 14, 120, 247, 69, 219, 112, 214, 227, 178, 126, 253, 132, 141, 44, 20, 163, 42, 18, 110, 5, 60, 17, 159, 176, 74, 108, 4, 195, 20, 126, 240, 197, 215, 50, 253, 241, 232, 111, 44, 187, 33, 121, 122, 52, 33, 8, 68, 87, 60, 251, 176, 2, 156, 189, 137, 169, 22, 79, 199, 137, 236, 30, 203, 186, 82, 43, 193, 32, 194, 235, 159, 234, 168, 96, 102, 154, 127, 80, 245, 123, 145, 173, 96, 44, 51, 2, 47, 93, 255, 99, 123, 207, 123, 118, 109, 140, 142, 229, 126, 152, 47, 183, 43, 20, 53, 89, 225, 110, 200, 74, 238, 57, 204, 82, 94, 114, 0, 240, 127, 238, 88, 213, 142, 12 } });
        }
    }
}
