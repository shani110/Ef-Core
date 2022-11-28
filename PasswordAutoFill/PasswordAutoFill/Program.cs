using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PasswordAutoFill.Data;
using PasswordAutoFill.Modules;
using System.Reflection;
using System.Reflection.Metadata;

public class Program
{
    public static DataContext context = new DataContext();

    // method to add users 
    public static void addUser(string name, string userName, string upassword) 
    {
        context.Database.ExecuteSqlRaw("exec user_insert {0},{1},{1}",name,userName,upassword);

    }
    //mehtod to print user details from view 

    public static void showUser() 
    {
        var list = context.users.FromSqlRaw(@"select * from u_view").ToList();
        foreach (var item in list)
        {
            Console.WriteLine("user id {0}, user name is {1}, user password is {2} ",item.userid,item.name,item.password);
        }
     
    }
   

    private static void Main(string[] args)
    {
        //addUser("muhammad", "isaa@sp", "3443422");
        //addUser("shani", "shani@sp", "3422");
        //addUser("alam", "alam@sp", "34232112");
        //addUser("akaram", "ak@sp", "22222");

        //context.SaveChanges();
        showUser();
        //context.SaveChanges();


    }
}