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
                name: "OperationClaims",
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
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
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
                        Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
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
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null }
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
                        90,
                        93,
                        68,
                        62,
                        180,
                        146,
                        0,
                        18,
                        31,
                        32,
                        181,
                        246,
                        138,
                        201,
                        47,
                        137,
                        47,
                        28,
                        22,
                        195,
                        199,
                        93,
                        184,
                        6,
                        10,
                        13,
                        0,
                        64,
                        91,
                        111,
                        146,
                        216,
                        34,
                        97,
                        167,
                        202,
                        149,
                        209,
                        94,
                        11,
                        99,
                        43,
                        37,
                        74,
                        167,
                        66,
                        231,
                        114,
                        49,
                        151,
                        91,
                        229,
                        199,
                        187,
                        253,
                        39,
                        220,
                        30,
                        72,
                        113,
                        42,
                        35,
                        38,
                        26
                    },
                    new byte[]
                    {
                        236,
                        33,
                        64,
                        38,
                        170,
                        100,
                        217,
                        7,
                        91,
                        65,
                        85,
                        180,
                        73,
                        0,
                        75,
                        73,
                        109,
                        123,
                        78,
                        155,
                        29,
                        148,
                        43,
                        212,
                        223,
                        45,
                        116,
                        192,
                        80,
                        249,
                        64,
                        112,
                        15,
                        74,
                        73,
                        38,
                        108,
                        45,
                        105,
                        234,
                        240,
                        42,
                        130,
                        197,
                        234,
                        7,
                        38,
                        232,
                        91,
                        243,
                        13,
                        39,
                        168,
                        106,
                        59,
                        6,
                        16,
                        49,
                        134,
                        46,
                        160,
                        231,
                        28,
                        239,
                        236,
                        107,
                        64,
                        139,
                        45,
                        242,
                        55,
                        131,
                        136,
                        168,
                        69,
                        149,
                        96,
                        88,
                        206,
                        18,
                        97,
                        136,
                        160,
                        196,
                        48,
                        63,
                        59,
                        204,
                        60,
                        153,
                        73,
                        113,
                        121,
                        160,
                        9,
                        177,
                        232,
                        57,
                        188,
                        186,
                        184,
                        24,
                        218,
                        236,
                        106,
                        61,
                        86,
                        143,
                        62,
                        63,
                        188,
                        227,
                        141,
                        190,
                        78,
                        76,
                        38,
                        51,
                        96,
                        164,
                        31,
                        9,
                        65,
                        42,
                        13,
                        214,
                        195,
                        206
                    },
                    true,
                    null,
                    1
                }
            );

            migrationBuilder.CreateIndex(
                name: "UK_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId",
                unique: true
            );

            migrationBuilder.CreateIndex(name: "UK_OperationClaims_Name", table: "OperationClaims", column: "Name", unique: true);

            migrationBuilder.CreateIndex(name: "UK_OtpAuthenticators_UserId", table: "OtpAuthenticators", column: "UserId", unique: true);

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

            migrationBuilder.DropTable(name: "RefreshTokens");

            migrationBuilder.DropTable(name: "UserGroupOperationClaims");

            migrationBuilder.DropTable(name: "Users");

            migrationBuilder.DropTable(name: "OperationClaims");

            migrationBuilder.DropTable(name: "UserGroups");
        }
    }
}
