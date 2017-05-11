using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using WebAPIApplication.Entities;
using WebAPIApplication.Model;

namespace WebAPIApplication.Model 
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context) 
        {
            context.Database.EnsureCreated();

            // Look for any TodoList.
            if (context.todoitems.Any())
            {
                return;   // DB has been seeded
            }

            var todoList = new TodoItem[]
            {
            new TodoItem{TodoItemID = 1, Task = "First task", IsComplete = false},
            new TodoItem{TodoItemID = 2, Task = "2 task", IsComplete = false},
            new TodoItem{TodoItemID = 3, Task = "3 task", IsComplete = true},
            new TodoItem{TodoItemID = 4, Task = "4 task", IsComplete = true}
            };
             foreach (TodoItem s in todoList)
            {
                context.todoitems.Add(s);
            }
           
            context.SaveChanges();
        }
    }
}
