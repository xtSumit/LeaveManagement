using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9ec1bea0-a7d0-4d6a-9818-382022ac0a67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "49b808c5-08af-42c8-bddc-1950578d7a84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "28c92f57-3ffe-49e6-b172-2efe5498525c", true, "User", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP7y3P3yvU8IFiWOIcjqpel3q53iO2dOUBYDDeLq0dc0d+Tg1rvNuHVFfWwgWSfh0A==", "bb40b9f5-118f-43a4-b400-981fab0493f1", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "43394a03-584c-4a6d-96e1-3d0360511221", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAzQ3JFQ35bHtm73oycBaHGBzw0NDHS7Zb/XAp9rFJmG/LvAId72EOtTUBgvlgOU7g==", "e0b5892f-5fca-45b8-8e4f-000b840d2b67", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6e0f1c92-fa5f-4e32-a21a-5cae8dba78ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "4f2539db-d213-4359-bb9a-7a0cb8372ec9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e5dd4ad-7654-4493-8c1f-637d6a3a47cc", false, "Admin", null, "AQAAAAEAACcQAAAAEAH+QPGgSeTioiOnbO4HZmMrl2S4O3Hhj7uYitDOIr9SkVMJDTIUhs0NU8/1mhXJIQ==", "96261d21-1574-4176-84ef-cdf7f0d671e9", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "621502cf-5323-4656-8f83-aa1a3c888b86", false, null, "AQAAAAEAACcQAAAAEOdjAeE2iig3CqgxmB62Dnpo/q+3WIcLKG6R1R/2GAj6V3tRYSZqC2K6bFqKRnM6OA==", "269e0bd2-542a-4d0e-908e-49f542564804", null });
        }
    }
}
