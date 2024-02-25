using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedLeaveRequestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5796b647-c330-4a26-a61f-14953646254c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6f94da3a-c68d-4902-9b3d-4591db73018f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45b179ca-53c7-4a52-a217-7ff554a01137", "AQAAAAEAACcQAAAAEE0TFvN1OzmdQyRV+MO6deaQdeex/S8X/LZWFMDxgzs7g0rMofwdsmIsptRQK7Kjdw==", "6621382a-ab2b-493e-8c62-b026cdc4b989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680e8485-5e08-4069-b2d9-b67915bbf9ac", "AQAAAAEAACcQAAAAEPCxAwPNMXZfPJivxRlr2en8PbizcFQNiBua4nQJW4wqK7bZLy0bUbOiKgglP7GcoA==", "e65892f0-b604-4c3a-b827-ffc1605f8820" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "53656c51-223d-4f22-a145-6221e5a66752");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "13405c21-25d2-4199-b9b0-86d973dcc0c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a28b90-9349-4ac3-8d23-0ee87648bbd7", "AQAAAAEAACcQAAAAENIh9Tz12y5Cguk8BhSDbjiq4sbvp2vbmmKrhuuZzzonShFBAL6U7l74hj1AEEiyQQ==", "2fc7548d-9892-47f6-b725-fe5aeca8c492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "badb84fd-8ee1-42ba-be07-edd056eedb95", "AQAAAAEAACcQAAAAEKq50tsuRYT/U+By41/WMPzl349QwMfkUZkMsjAFp/QGhczJlbza/LTCe+o279J1iw==", "2e42d6e6-52cf-41ed-984a-14753a5308b6" });
        }
    }
}
