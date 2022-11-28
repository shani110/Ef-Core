using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    public partial class autofill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "credentials",
                columns: table => new
                {
                    credentialid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    websiteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credentials", x => x.credentialid);
                });

            migrationBuilder.CreateTable(
                name: "histories",
                columns: table => new
                {
                    historyid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    credentialid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    websiteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histories", x => x.historyid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "websites",
                columns: table => new
                {
                    websiteid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    webAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_websites", x => x.websiteid);
                });

            migrationBuilder.CreateTable(
                name: "CredentialHistory",
                columns: table => new
                {
                    Credentialscredentialid = table.Column<int>(type: "int", nullable: false),
                    historyid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialHistory", x => new { x.Credentialscredentialid, x.historyid });
                    table.ForeignKey(
                        name: "FK_CredentialHistory_credentials_Credentialscredentialid",
                        column: x => x.Credentialscredentialid,
                        principalTable: "credentials",
                        principalColumn: "credentialid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredentialHistory_histories_historyid",
                        column: x => x.historyid,
                        principalTable: "histories",
                        principalColumn: "historyid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CredentialUser",
                columns: table => new
                {
                    credentialid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialUser", x => new { x.credentialid, x.userid });
                    table.ForeignKey(
                        name: "FK_CredentialUser_credentials_credentialid",
                        column: x => x.credentialid,
                        principalTable: "credentials",
                        principalColumn: "credentialid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredentialUser_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryUser",
                columns: table => new
                {
                    historyid = table.Column<int>(type: "int", nullable: false),
                    usersuserid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryUser", x => new { x.historyid, x.usersuserid });
                    table.ForeignKey(
                        name: "FK_HistoryUser_histories_historyid",
                        column: x => x.historyid,
                        principalTable: "histories",
                        principalColumn: "historyid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryUser_users_usersuserid",
                        column: x => x.usersuserid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CredentialWebsite",
                columns: table => new
                {
                    credentialscredentialid = table.Column<int>(type: "int", nullable: false),
                    websiteswebsiteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialWebsite", x => new { x.credentialscredentialid, x.websiteswebsiteid });
                    table.ForeignKey(
                        name: "FK_CredentialWebsite_credentials_credentialscredentialid",
                        column: x => x.credentialscredentialid,
                        principalTable: "credentials",
                        principalColumn: "credentialid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredentialWebsite_websites_websiteswebsiteid",
                        column: x => x.websiteswebsiteid,
                        principalTable: "websites",
                        principalColumn: "websiteid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryWebsite",
                columns: table => new
                {
                    historyid = table.Column<int>(type: "int", nullable: false),
                    websiteswebsiteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryWebsite", x => new { x.historyid, x.websiteswebsiteid });
                    table.ForeignKey(
                        name: "FK_HistoryWebsite_histories_historyid",
                        column: x => x.historyid,
                        principalTable: "histories",
                        principalColumn: "historyid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryWebsite_websites_websiteswebsiteid",
                        column: x => x.websiteswebsiteid,
                        principalTable: "websites",
                        principalColumn: "websiteid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CredentialHistory_historyid",
                table: "CredentialHistory",
                column: "historyid");

            migrationBuilder.CreateIndex(
                name: "IX_CredentialUser_userid",
                table: "CredentialUser",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_CredentialWebsite_websiteswebsiteid",
                table: "CredentialWebsite",
                column: "websiteswebsiteid");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryUser_usersuserid",
                table: "HistoryUser",
                column: "usersuserid");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryWebsite_websiteswebsiteid",
                table: "HistoryWebsite",
                column: "websiteswebsiteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CredentialHistory");

            migrationBuilder.DropTable(
                name: "CredentialUser");

            migrationBuilder.DropTable(
                name: "CredentialWebsite");

            migrationBuilder.DropTable(
                name: "HistoryUser");

            migrationBuilder.DropTable(
                name: "HistoryWebsite");

            migrationBuilder.DropTable(
                name: "credentials");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "histories");

            migrationBuilder.DropTable(
                name: "websites");
        }
    }
}
