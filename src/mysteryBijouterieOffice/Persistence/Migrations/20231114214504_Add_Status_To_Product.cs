using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Status_To_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 37, 102, 203, 144, 188, 211, 136, 164, 101, 44, 30, 240, 229, 77, 169, 15, 122, 82, 61, 21, 138, 35, 209, 160, 105, 194, 120, 49, 246, 235, 26, 44, 69, 11, 20, 238, 57, 153, 92, 116, 18, 197, 49, 174, 38, 112, 34, 173, 114, 214, 121, 42, 171, 29, 2, 33, 200, 113, 69, 207, 25, 30, 116 }, new byte[] { 180, 12, 160, 138, 41, 191, 194, 45, 158, 41, 238, 32, 3, 37, 7, 53, 225, 64, 70, 99, 102, 10, 2, 254, 197, 35, 138, 216, 212, 205, 218, 189, 18, 53, 150, 172, 38, 122, 130, 195, 73, 145, 99, 33, 243, 224, 128, 136, 7, 48, 7, 122, 192, 35, 90, 236, 107, 17, 179, 96, 157, 10, 201, 198, 80, 1, 178, 60, 170, 183, 20, 178, 254, 235, 221, 53, 123, 183, 152, 252, 89, 24, 27, 32, 126, 141, 213, 234, 62, 203, 66, 47, 198, 28, 24, 69, 37, 7, 234, 132, 189, 157, 131, 203, 69, 17, 142, 253, 225, 132, 108, 97, 214, 169, 74, 224, 237, 109, 31, 102, 117, 85, 16, 64, 191, 35, 223, 72 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 21, 135, 252, 42, 51, 143, 8, 219, 212, 165, 172, 31, 69, 160, 128, 33, 36, 19, 50, 69, 147, 4, 15, 180, 105, 244, 87, 13, 40, 202, 143, 26, 134, 79, 35, 151, 224, 226, 140, 126, 85, 82, 92, 215, 218, 156, 127, 181, 213, 229, 121, 63, 15, 180, 129, 78, 29, 232, 124, 138, 73, 176, 16, 25 }, new byte[] { 201, 242, 59, 154, 173, 131, 149, 166, 150, 189, 40, 4, 83, 209, 66, 34, 13, 84, 204, 224, 105, 170, 1, 0, 246, 172, 17, 63, 97, 207, 27, 21, 123, 76, 255, 58, 18, 139, 219, 118, 201, 45, 157, 101, 110, 164, 50, 179, 25, 3, 54, 119, 125, 86, 107, 39, 135, 227, 31, 78, 3, 134, 72, 177, 94, 13, 9, 85, 210, 136, 79, 1, 206, 135, 114, 254, 120, 120, 100, 216, 75, 209, 97, 61, 115, 200, 163, 0, 96, 241, 176, 15, 214, 224, 47, 232, 175, 166, 64, 179, 224, 0, 245, 115, 72, 75, 32, 134, 111, 137, 223, 184, 223, 84, 125, 98, 183, 199, 78, 26, 176, 234, 70, 30, 204, 186, 208, 28 } });
        }
    }
}
