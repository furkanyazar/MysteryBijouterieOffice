﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20231114214504_Add_Status_To_Product")]
    partial class Add_Status_To_Product
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Security.Entities.EmailAuthenticator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActivationKey")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ActivationKey");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit")
                        .HasColumnName("IsVerified");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "UK_EmailAuthenticators_UserId")
                        .IsUnique();

                    b.ToTable("EmailAuthenticators", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Name");

                    b.Property<int?>("ParentOperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("ParentOperationClaimId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Value");

                    b.HasKey("Id");

                    b.HasIndex("ParentOperationClaimId");

                    b.HasIndex(new[] { "Name" }, "UK_OperationClaims_Name")
                        .IsUnique();

                    b.HasIndex(new[] { "Value" }, "UK_OperationClaims_Value")
                        .IsUnique();

                    b.ToTable("OperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            Value = "admin"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.OtpAuthenticator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit")
                        .HasColumnName("IsVerified");

                    b.Property<byte[]>("SecretKey")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("SecretKey");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "UK_OtpAuthenticators_UserId")
                        .IsUnique();

                    b.ToTable("OtpAuthenticators", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CreatedByIp");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2")
                        .HasColumnName("Expires");

                    b.Property<string>("ReasonRevoked")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ReasonRevoked");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ReplacedByToken");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2")
                        .HasColumnName("Revoked");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RevokedByIp");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Token");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "Token" }, "UK_RefreshTokens_Token")
                        .IsUnique();

                    b.ToTable("RefreshTokens", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthenticatorType")
                        .HasColumnType("int")
                        .HasColumnName("AuthenticatorType");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int")
                        .HasColumnName("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("UserGroupId");

                    b.HasIndex(new[] { "Email" }, "UK_Users_Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthenticatorType = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@mail.com",
                            FirstName = "Test",
                            LastName = "Mail",
                            PasswordHash = new byte[] { 222, 37, 102, 203, 144, 188, 211, 136, 164, 101, 44, 30, 240, 229, 77, 169, 15, 122, 82, 61, 21, 138, 35, 209, 160, 105, 194, 120, 49, 246, 235, 26, 44, 69, 11, 20, 238, 57, 153, 92, 116, 18, 197, 49, 174, 38, 112, 34, 173, 114, 214, 121, 42, 171, 29, 2, 33, 200, 113, 69, 207, 25, 30, 116 },
                            PasswordSalt = new byte[] { 180, 12, 160, 138, 41, 191, 194, 45, 158, 41, 238, 32, 3, 37, 7, 53, 225, 64, 70, 99, 102, 10, 2, 254, 197, 35, 138, 216, 212, 205, 218, 189, 18, 53, 150, 172, 38, 122, 130, 195, 73, 145, 99, 33, 243, 224, 128, 136, 7, 48, 7, 122, 192, 35, 90, 236, 107, 17, 179, 96, 157, 10, 201, 198, 80, 1, 178, 60, 170, 183, 20, 178, 254, 235, 221, 53, 123, 183, 152, 252, 89, 24, 27, 32, 126, 141, 213, 234, 62, 203, 66, 47, 198, 28, 24, 69, 37, 7, 234, 132, 189, 157, 131, 203, 69, 17, 142, 253, 225, 132, 108, 97, 214, 169, 74, 224, 237, 109, 31, 102, 117, 85, 16, 64, 191, 35, 223, 72 },
                            Status = true,
                            UserGroupId = 1
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UK_UserGroups_Name")
                        .IsUnique();

                    b.ToTable("UserGroups", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserGroupOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int")
                        .HasColumnName("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex(new[] { "UserGroupId", "OperationClaimId" }, "UK_UserGroupOperationClaims_UserGroupId_OperationClaimId")
                        .IsUnique();

                    b.ToTable("UserGroupOperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OperationClaimId = 1,
                            UserGroupId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UK_Categories_Name")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CategoryPartner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<double>("CommissionRate")
                        .HasColumnType("float")
                        .HasColumnName("CommissionRate");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int")
                        .HasColumnName("PartnerId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.HasIndex(new[] { "CategoryId", "PartnerId" }, "UK_CategoryPartners_CategoryId_PartnerId")
                        .IsUnique();

                    b.ToTable("CategoryPartners", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<decimal>("FreeShippingLowerLimit")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("FreeShippingLowerLimit");

                    b.Property<bool>("HasFreeShipping")
                        .HasColumnType("bit")
                        .HasColumnName("HasFreeShipping");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Name");

                    b.Property<decimal>("ServiceFee")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("ServiceFee");

                    b.Property<decimal>("ShippingCost")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("ShippingCost");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UK_Partners_Name")
                        .IsUnique();

                    b.ToTable("Partners", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BarcodeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BarcodeNumber");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ModelNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("UnitPrice");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex(new[] { "BarcodeNumber" }, "UK_Products_BarcodeNumber")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.EmailAuthenticator", b =>
                {
                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("EmailAuthenticators")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.HasOne("Core.Security.Entities.OperationClaim", "ParentOperationClaim")
                        .WithMany()
                        .HasForeignKey("ParentOperationClaimId");

                    b.Navigation("ParentOperationClaim");
                });

            modelBuilder.Entity("Core.Security.Entities.OtpAuthenticator", b =>
                {
                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("OtpAuthenticators")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Security.Entities.RefreshToken", b =>
                {
                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.HasOne("Core.Security.Entities.UserGroup", "UserGroup")
                        .WithMany("Users")
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserGroup");
                });

            modelBuilder.Entity("Core.Security.Entities.UserGroupOperationClaim", b =>
                {
                    b.HasOne("Core.Security.Entities.OperationClaim", "OperationClaim")
                        .WithMany("UserGroupOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.UserGroup", "UserGroup")
                        .WithMany("UserGroupOperationClaims")
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("UserGroup");
                });

            modelBuilder.Entity("Domain.Entities.CategoryPartner", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("CategoryPartners")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Partner", "Partner")
                        .WithMany("CategoryPartners")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.Navigation("UserGroupOperationClaims");
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Navigation("EmailAuthenticators");

                    b.Navigation("OtpAuthenticators");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Core.Security.Entities.UserGroup", b =>
                {
                    b.Navigation("UserGroupOperationClaims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("CategoryPartners");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Partner", b =>
                {
                    b.Navigation("CategoryPartners");
                });
#pragma warning restore 612, 618
        }
    }
}