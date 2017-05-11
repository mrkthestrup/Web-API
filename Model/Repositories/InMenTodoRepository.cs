using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplication.Entities;

namespace WebAPIApplication.Repositories
{
    public class InMenTodoRepository : ITodoRepository
    {
        List<TodoItem> todoList;

        //tom konstruktør!
        public InMenTodoRepository()
        {
            todoList = new List<TodoItem>();
            todoList.Add(new TodoItem{TodoItemID = 1, Task = "First task", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 2, Task = "2 task", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 3, Task = "3 task", IsComplete = true});
            todoList.Add(new TodoItem{TodoItemID = 4, Task = "4 task", IsComplete = true});

        }

        public void Delete(TodoItem id)
        {
            throw new NotImplementedException();
        }

        public TodoItem Get(int id)
        {
            return todoList.Find(item => item.TodoItemID == id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return todoList;
        }

        public void Save(TodoItem TodoItem)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem TodoItem)
        {
            throw new NotImplementedException();
        }
    }
}
