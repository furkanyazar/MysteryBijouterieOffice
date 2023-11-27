using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Partner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeShippingLowerLimit",
                table: "Partners");

            migrationBuilder.RenameColumn(
                name: "HasFreeShipping",
                table: "Partners",
                newName: "HasSecondScale");

            migrationBuilder.AddColumn<decimal>(
                name: "FirstScaleLowerLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FirstScaleShippingFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FirstScaleUpperLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasFirstScale",
                table: "Partners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondScaleLowerLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondScaleShippingFee",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondScaleUpperLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 200, 208, 107, 247, 49, 38, 250, 65, 38, 85, 95, 183, 172, 72, 67, 253, 43, 230, 226, 73, 37, 24, 12, 17, 32, 7, 179, 57, 195, 144, 130, 166, 128, 213, 89, 251, 97, 141, 198, 139, 189, 94, 222, 2, 6, 12, 172, 143, 155, 142, 74, 34, 120, 22, 26, 47, 104, 211, 31, 65, 57, 177, 138 }, new byte[] { 97, 8, 221, 238, 165, 153, 18, 60, 122, 68, 222, 175, 234, 221, 195, 190, 191, 133, 15, 251, 123, 11, 150, 179, 254, 179, 155, 144, 135, 199, 220, 190, 11, 69, 243, 149, 163, 177, 233, 244, 251, 12, 160, 183, 124, 245, 88, 53, 60, 169, 102, 83, 252, 65, 194, 174, 249, 83, 214, 108, 150, 241, 108, 231, 209, 255, 199, 135, 237, 187, 15, 103, 75, 159, 47, 9, 60, 50, 65, 56, 95, 198, 6, 226, 189, 141, 50, 168, 200, 155, 6, 77, 209, 121, 186, 91, 253, 73, 231, 48, 111, 161, 180, 58, 1, 83, 43, 142, 113, 192, 38, 52, 139, 131, 120, 130, 14, 183, 116, 59, 42, 236, 131, 221, 181, 229, 107, 92 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstScaleLowerLimit",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "FirstScaleShippingFee",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "FirstScaleUpperLimit",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "HasFirstScale",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SecondScaleLowerLimit",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SecondScaleShippingFee",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SecondScaleUpperLimit",
                table: "Partners");

            migrationBuilder.RenameColumn(
                name: "HasSecondScale",
                table: "Partners",
                newName: "HasFreeShipping");

            migrationBuilder.AddColumn<decimal>(
                name: "FreeShippingLowerLimit",
                table: "Partners",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 117, 38, 70, 153, 34, 230, 79, 128, 203, 58, 133, 58, 25, 111, 61, 150, 206, 220, 187, 126, 114, 153, 102, 232, 133, 225, 136, 172, 127, 250, 134, 34, 23, 227, 220, 235, 185, 249, 113, 74, 201, 101, 252, 139, 78, 35, 68, 78, 5, 189, 38, 189, 219, 67, 121, 154, 248, 131, 197, 128, 166, 111, 250, 243 }, new byte[] { 145, 170, 15, 191, 172, 95, 203, 13, 138, 93, 252, 213, 107, 116, 204, 122, 230, 74, 247, 233, 100, 202, 245, 210, 220, 145, 169, 235, 220, 59, 41, 113, 41, 250, 218, 48, 134, 57, 82, 89, 136, 179, 242, 218, 128, 47, 17, 143, 109, 156, 158, 210, 176, 45, 78, 56, 11, 24, 191, 78, 240, 241, 62, 135, 175, 187, 133, 60, 136, 163, 143, 73, 84, 194, 178, 203, 216, 135, 211, 160, 61, 155, 194, 253, 15, 41, 216, 0, 172, 246, 198, 253, 41, 99, 83, 216, 162, 129, 199, 8, 82, 28, 166, 92, 178, 139, 125, 41, 155, 189, 118, 143, 95, 184, 50, 89, 249, 200, 65, 233, 50, 162, 170, 211, 207, 217, 142, 63 } });
        }
    }
}
