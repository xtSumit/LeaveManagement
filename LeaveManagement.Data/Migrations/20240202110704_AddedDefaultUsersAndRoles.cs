using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "6e0f1c92-fa5f-4e32-a21a-5cae8dba78ac", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "4f2539db-d213-4359-bb9a-7a0cb8372ec9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f100b4a-821c-440e-b8d9-bf80a4406e33", 0, "7e5dd4ad-7654-4493-8c1f-637d6a3a47cc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "Admin", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEAH+QPGgSeTioiOnbO4HZmMrl2S4O3Hhj7uYitDOIr9SkVMJDTIUhs0NU8/1mhXJIQ==", null, false, "96261d21-1574-4176-84ef-cdf7f0d671e9", null, false, null },
                    { "c361c40d-561e-494b-a7f6-f5e03f4ef1b2", 0, "621502cf-5323-4656-8f83-aa1a3c888b86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOdjAeE2iig3CqgxmB62Dnpo/q+3WIcLKG6R1R/2GAj6V3tRYSZqC2K6bFqKRnM6OA==", null, false, "269e0bd2-542a-4d0e-908e-49f542564804", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "0f100b4a-821c-440e-b8d9-bf80a4406e33" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "c361c40d-561e-494b-a7f6-f5e03f4ef1b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "0f100b4a-821c-440e-b8d9-bf80a4406e33" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "c361c40d-561e-494b-a7f6-f5e03f4ef1b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2");
        }
    }
}
