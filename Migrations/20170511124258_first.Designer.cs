using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPIApplication.Model;

namespace WebAPIApplication.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170511124258_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("WebAPIApplication.Entities.TodoItem", b =>
                {
                    b.Property<int>("TodoItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Task");

                    b.HasKey("TodoItemID");

                    b.ToTable("todoitems");
                });
        }
    }
}
