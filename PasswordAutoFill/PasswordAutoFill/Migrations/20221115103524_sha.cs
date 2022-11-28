using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    public partial class sha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "credentials",
                keyColumn: "credentialid",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "credentials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "credentials");

            migrationBuilder.InsertData(
                table: "credentials",
                columns: new[] { "credentialid", "NewPassword", "userid", "username", "websiteid" },
                values: new object[] { 1, "12345", 1, "isa", 2 });
        }
    }
}
