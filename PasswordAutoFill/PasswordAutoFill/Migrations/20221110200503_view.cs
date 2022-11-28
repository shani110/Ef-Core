using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    public partial class view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var viv = @"create view u_view 
                                       as
                              select * from users;
                       ";
            

            migrationBuilder.Sql(viv);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view u_view");

        }
    }
}
