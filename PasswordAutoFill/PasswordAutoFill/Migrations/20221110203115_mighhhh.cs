using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    public partial class mighhhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "credentials",
                columns: new[] { "credentialid", "NewPassword", "userid", "username", "websiteid" },
                values: new object[] { 1, "12345", 1, "isa", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "credentials",
                keyColumn: "credentialid",
                keyValue: 1);
        }
    }
}
