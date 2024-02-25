using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocatuons_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocatuons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocatuons",
                table: "LeaveAllocatuons");

            migrationBuilder.RenameTable(
                name: "LeaveAllocatuons",
                newName: "LeaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocatuons_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canclled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "LeaveAllocatuons");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocatuons",
                newName: "IX_LeaveAllocatuons_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocatuons",
                table: "LeaveAllocatuons",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "abd1ba91-e03c-45c6-ac5c-badc8e7b1f84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "108bb25c-c950-4a33-b3aa-a0ea6c2766b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "390dce6c-61b8-484e-b7cb-0ef32245a4f8", "AQAAAAEAACcQAAAAEDoHUP0/CNZeIGn0tjaAlKj+VGsu3tIeWem1u0eqB+AIZ47tEyMWrNNCzg61bns2cg==", "7e38727f-a16a-4ad1-b696-80791a7f0d5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "693b7334-9186-4562-9493-aa561ffd9f2a", "AQAAAAEAACcQAAAAEJ9lRCbyjlSgEO8W1+4rEU7n1YATWuSZS0eXmrqGmsT6c5YNjshPl6Y8GtVP/yvL4A==", "434a1160-5ce3-493f-9f66-7340fecb7f02" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocatuons_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocatuons",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
