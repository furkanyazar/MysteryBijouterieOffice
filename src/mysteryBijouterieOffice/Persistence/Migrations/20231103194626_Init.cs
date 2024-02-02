using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        ParentOperationClaimId = table.Column<int>(type: "int", nullable: true),
                        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        Value = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationClaims_OperationClaims_ParentOperationClaimId",
                        column: x => x.ParentOperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        CategoryId = table.Column<int>(type: "int", nullable: false),
                        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserGroupOperationClaims",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        UserGroupId = table.Column<int>(type: "int", nullable: false),
                        OperationClaimId = table.Column<int>(type: "int", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroupOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGroupOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserGroupOperationClaims_UserGroups_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "UserGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        UserGroupId = table.Column<int>(type: "int", nullable: false),
                        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                        PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                        Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                        AuthenticatorType = table.Column<int>(type: "int", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserGroups_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "UserGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "EmailAuthenticators",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        UserId = table.Column<int>(type: "int", nullable: false),
                        ActivationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        IsVerified = table.Column<bool>(type: "bit", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "OtpAuthenticators",
                columns: table =>
                    new
                    {
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                        UserId = table.Column<int>(type: "int", nullable: false),
                        SecretKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                        IsVerified = table.Column<bool>(type: "bit", nullable: false),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table =>
                    new
                    {
                        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                        UserId = table.Column<int>(type: "int", nullable: false),
                        Token = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                        CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                        RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "ParentOperationClaimId", "UpdatedDate", "Value" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null, null, "admin" }
            );

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null }
            );

            migrationBuilder.InsertData(
                table: "UserGroupOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserGroupId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, 1 }
            );

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[]
                {
                    "Id",
                    "AuthenticatorType",
                    "CreatedDate",
                    "DeletedDate",
                    "Email",
                    "FirstName",
                    "LastName",
                    "PasswordHash",
                    "PasswordSalt",
                    "Status",
                    "UpdatedDate",
                    "UserGroupId"
                },
                values: new object[]
                {
                    1,
                    0,
                    new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    null,
                    "test@mail.com",
                    "Test",
                    "Mail",
                    new byte[]
                    {
                        122,
                        158,
                        162,
                        107,
                        125,
                        147,
                        75,
                        93,
                        202,
                        88,
                        38,
                        156,
                        254,
                        239,
                        145,
                        36,
                        68,
                        90,
                        242,
                        120,
                        160,
                        117,
                        136,
                        42,
                        161,
                        236,
                        178,
                        222,
                        65,
                        172,
                        182,
                        134,
                        83,
                        244,
                        210,
                        41,
                        243,
                        213,
                        63,
                        64,
                        194,
                        191,
                        240,
                        231,
                        30,
                        192,
                        172,
                        120,
                        225,
                        45,
                        178,
                        165,
                        198,
                        36,
                        173,
                        228,
                        113,
                        147,
                        127,
                        0,
                        87,
                        167,
                        175,
                        35
                    },
                    new byte[]
                    {
                        149,
                        216,
                        245,
                        155,
                        14,
                        120,
                        247,
                        69,
                        219,
                        112,
                        214,
                        227,
                        178,
                        126,
                        253,
                        132,
                        141,
                        44,
                        20,
                        163,
                        42,
                        18,
                        110,
                        5,
                        60,
                        17,
                        159,
                        176,
                        74,
                        108,
                        4,
                        195,
                        20,
                        126,
                        240,
                        197,
                        215,
                        50,
                        253,
                        241,
                        232,
                        111,
                        44,
                        187,
                        33,
                        121,
                        122,
                        52,
                        33,
                        8,
                        68,
                        87,
                        60,
                        251,
                        176,
                        2,
                        156,
                        189,
                        137,
                        169,
                        22,
                        79,
                        199,
                        137,
                        236,
                        30,
                        203,
                        186,
                        82,
                        43,
                        193,
                        32,
                        194,
                        235,
                        159,
                        234,
                        168,
                        96,
                        102,
                        154,
                        127,
                        80,
                        245,
                        123,
                        145,
                        173,
                        96,
                        44,
                        51,
                        2,
                        47,
                        93,
                        255,
                        99,
                        123,
                        207,
                        123,
                        118,
                        109,
                        140,
                        142,
                        229,
                        126,
                        152,
                        47,
                        183,
                        43,
                        20,
                        53,
                        89,
                        225,
                        110,
                        200,
                        74,
                        238,
                        57,
                        204,
                        82,
                        94,
                        114,
                        0,
                        240,
                        127,
                        238,
                        88,
                        213,
                        142,
                        12
                    },
                    true,
                    null,
                    1
                }
            );

            migrationBuilder.CreateIndex(name: "UK_Categories_Name", table: "Categories", column: "Name", unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_ParentOperationClaimId",
                table: "OperationClaims",
                column: "ParentOperationClaimId"
            );

            migrationBuilder.CreateIndex(name: "UK_OperationClaims_Name", table: "OperationClaims", column: "Name", unique: true);

            migrationBuilder.CreateIndex(name: "UK_OperationClaims_Value", table: "OperationClaims", column: "Value", unique: true);

            migrationBuilder.CreateIndex(name: "UK_OtpAuthenticators_UserId", table: "OtpAuthenticators", column: "UserId", unique: true);

            migrationBuilder.CreateIndex(name: "IX_Products_CategoryId", table: "Products", column: "CategoryId");

            migrationBuilder.CreateIndex(name: "UK_Products_Name", table: "Products", column: "Name", unique: true);

            migrationBuilder.CreateIndex(name: "IX_RefreshTokens_UserId", table: "RefreshTokens", column: "UserId");

            migrationBuilder.CreateIndex(name: "UK_RefreshTokens_Token", table: "RefreshTokens", column: "Token", unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserGroupOperationClaims_OperationClaimId",
                table: "UserGroupOperationClaims",
                column: "OperationClaimId"
            );

            migrationBuilder.CreateIndex(
                name: "UK_UserGroupOperationClaims_UserGroupId_OperationClaimId",
                table: "UserGroupOperationClaims",
                columns: new[] { "UserGroupId", "OperationClaimId" },
                unique: true
            );

            migrationBuilder.CreateIndex(name: "UK_UserGroups_Name", table: "UserGroups", column: "Name", unique: true);

            migrationBuilder.CreateIndex(name: "IX_Users_UserGroupId", table: "Users", column: "UserGroupId");

            migrationBuilder.CreateIndex(name: "UK_Users_Email", table: "Users", column: "Email", unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "EmailAuthenticators");

            migrationBuilder.DropTable(name: "OtpAuthenticators");

            migrationBuilder.DropTable(name: "Products");

            migrationBuilder.DropTable(name: "RefreshTokens");

            migrationBuilder.DropTable(name: "UserGroupOperationClaims");

            migrationBuilder.DropTable(name: "Categories");

            migrationBuilder.DropTable(name: "Users");

            migrationBuilder.DropTable(name: "OperationClaims");

            migrationBuilder.DropTable(name: "UserGroups");
        }
    }
}
