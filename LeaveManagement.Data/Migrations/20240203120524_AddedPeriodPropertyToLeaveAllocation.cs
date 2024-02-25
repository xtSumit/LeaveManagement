using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedPeriodPropertyToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocatuons",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocatuons");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c92f57-3ffe-49e6-b172-2efe5498525c", "AQAAAAEAACcQAAAAEP7y3P3yvU8IFiWOIcjqpel3q53iO2dOUBYDDeLq0dc0d+Tg1rvNuHVFfWwgWSfh0A==", "bb40b9f5-118f-43a4-b400-981fab0493f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43394a03-584c-4a6d-96e1-3d0360511221", "AQAAAAEAACcQAAAAEAzQ3JFQ35bHtm73oycBaHGBzw0NDHS7Zb/XAp9rFJmG/LvAId72EOtTUBgvlgOU7g==", "e0b5892f-5fca-45b8-8e4f-000b840d2b67" });
        }
    }
}
