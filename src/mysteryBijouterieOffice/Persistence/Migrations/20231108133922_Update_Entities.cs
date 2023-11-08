using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CommissionRate",
                table: "CategoryPartners",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 121, 172, 22, 229, 110, 185, 135, 65, 204, 195, 234, 39, 121, 179, 208, 169, 198, 140, 199, 245, 255, 199, 134, 140, 122, 27, 225, 105, 248, 135, 124, 96, 132, 127, 242, 126, 44, 209, 214, 14, 61, 139, 208, 137, 49, 23, 7, 106, 40, 143, 212, 70, 29, 36, 21, 250, 214, 39, 224, 195, 144, 119, 75 }, new byte[] { 172, 84, 50, 167, 74, 180, 217, 83, 78, 139, 168, 57, 144, 221, 138, 230, 21, 193, 95, 178, 16, 102, 162, 54, 160, 104, 168, 216, 190, 204, 63, 180, 158, 75, 211, 180, 145, 186, 68, 95, 84, 255, 222, 79, 41, 28, 211, 201, 183, 20, 69, 43, 213, 190, 133, 219, 98, 246, 254, 224, 36, 212, 187, 84, 21, 94, 134, 92, 151, 33, 167, 163, 71, 249, 124, 203, 157, 170, 42, 98, 52, 214, 90, 115, 65, 163, 177, 193, 130, 18, 230, 160, 42, 134, 245, 98, 143, 144, 132, 124, 51, 160, 128, 227, 65, 228, 245, 185, 152, 183, 6, 234, 131, 213, 102, 36, 118, 199, 226, 87, 83, 236, 249, 143, 206, 167, 97, 233 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommissionRate",
                table: "CategoryPartners",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 200, 136, 183, 136, 156, 81, 196, 22, 196, 65, 13, 220, 38, 236, 132, 4, 229, 252, 148, 203, 130, 7, 65, 46, 93, 116, 167, 112, 172, 87, 0, 202, 129, 32, 45, 170, 61, 171, 37, 178, 8, 148, 52, 239, 233, 188, 83, 53, 79, 229, 99, 219, 61, 103, 121, 219, 246, 180, 250, 111, 152, 192, 126 }, new byte[] { 240, 230, 112, 230, 103, 130, 57, 181, 83, 71, 102, 191, 168, 3, 241, 127, 51, 55, 212, 220, 70, 185, 61, 61, 19, 28, 230, 41, 203, 14, 235, 82, 202, 75, 216, 189, 18, 7, 152, 70, 4, 15, 99, 145, 207, 211, 245, 148, 17, 135, 11, 252, 30, 34, 28, 189, 123, 84, 245, 137, 122, 235, 122, 98, 3, 254, 119, 74, 197, 235, 244, 186, 200, 184, 12, 127, 213, 100, 182, 75, 183, 154, 245, 187, 128, 93, 208, 230, 128, 10, 180, 193, 26, 68, 29, 122, 187, 140, 191, 191, 106, 56, 47, 109, 62, 185, 167, 173, 129, 182, 105, 97, 77, 141, 74, 42, 28, 47, 118, 168, 201, 201, 121, 201, 88, 147, 128, 220 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
