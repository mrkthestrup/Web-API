using Microsoft.EntityFrameworkCore;
using WebAPIApplication.Entities;


namespace WebAPIApplication.Model

{
    public class MyDbContext : DbContext
    {

         public DbSet<TodoItem> todoitems { get; set; }
         
           protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 
    }
}