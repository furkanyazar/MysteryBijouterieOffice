using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ImageUrl_And_Description_To_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ServiceFee",
                table: "CategoryPartners");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 199, 14, 211, 27, 34, 106, 73, 107, 40, 50, 23, 36, 252, 193, 88, 154, 188, 43, 244, 236, 2, 20, 87, 175, 116, 60, 241, 249, 86, 24, 120, 23, 62, 8, 136, 26, 140, 255, 40, 143, 40, 242, 254, 243, 91, 147, 200, 25, 49, 41, 84, 193, 36, 193, 15, 105, 94, 198, 83, 98, 182, 119, 229 }, new byte[] { 252, 219, 144, 80, 21, 177, 35, 166, 211, 87, 164, 240, 71, 8, 48, 116, 33, 39, 40, 3, 175, 196, 147, 192, 78, 248, 181, 83, 166, 160, 42, 23, 49, 7, 65, 0, 42, 161, 44, 174, 189, 52, 125, 26, 150, 228, 207, 148, 10, 74, 246, 159, 160, 165, 175, 191, 36, 242, 182, 171, 158, 4, 85, 186, 39, 20, 152, 233, 150, 47, 152, 0, 209, 25, 52, 205, 62, 255, 237, 12, 7, 49, 67, 128, 252, 29, 176, 11, 102, 114, 128, 169, 159, 96, 36, 136, 189, 97, 84, 66, 125, 116, 168, 126, 205, 173, 98, 17, 140, 48, 107, 34, 193, 173, 203, 237, 217, 254, 34, 216, 170, 0, 64, 54, 118, 157, 161, 80 } });
        }
    }
}
