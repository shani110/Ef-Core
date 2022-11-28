using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    public partial class procedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var ins = @"CREATE PROCEDURE user_insert
                    
           @name varchar(max), @userName varchar(max),@pas varchar(max)
                                 as
            insert into users(name,userName,password) values (@name,@userName,@pas)



                      ";
           
            migrationBuilder.Sql(ins);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
