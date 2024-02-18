using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class RestoredProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Canclled",
                table: "LeaveRequests",
                newName: "Cancelled");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "34a5bb28-d8ab-4a2a-adf0-197f4a19142f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "763ff01e-851b-43f7-8350-860db3ae6141");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f100b4a-821c-440e-b8d9-bf80a4406e33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8388b859-ccb6-41ab-8f29-9ac613a02f35", "AQAAAAEAACcQAAAAEDbC+DYSR07ijJ52TcxMONbPj2KAuhDS9tP98DvT/razf01pnSkD4H5AR3kO2RdSsg==", "6d17ce3d-0bad-4aa8-ae57-e4f9aaf5d763" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c361c40d-561e-494b-a7f6-f5e03f4ef1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11b9f3b-4d0d-4c85-9cc9-e810587e930f", "AQAAAAEAACcQAAAAEI1Be8IOFzVJPOjRj36IOmmt2EnNRFhkEfehmwjH8oWmFYDoN5scaNuBZCtRtmvaVA==", "3690a223-cec1-4748-8644-325697954f6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cancelled",
                table: "LeaveRequests",
                newName: "Canclled");

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
    }
}
