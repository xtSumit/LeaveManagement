using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangedEmployeeIdTypeToStringLeaveAllocationClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocatuons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocatuons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "88f9b91f-d8a7-4071-9766-82eb2592f2c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "90fc36bc-d467-4ce2-9ed1-123da2f1c0ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ad4f941-547c-4186-8a14-568bdb63f57f", "AQAAAAEAACcQAAAAEPL9KQXdQ2z3Ge49hFAVG9KuzdJ5X/azLZXMw2AEtt9sZtV7wV83dhS0wU2sPCpoAw==", "fe35fa25-cd34-41e1-9852-8f89ade1022d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62f9028-ecb9-4406-9d7b-7c8142f09910", "AQAAAAEAACcQAAAAEMCXi1hr6qEOBpQLd+IkRJR/SbOFKeeohW8wZAqyf0C+kP86Hc+a1ue00KqtbHGViQ==", "89993ad0-c9b3-4d70-ab1e-d87c7eba0ca7" });
        }
    }
}
