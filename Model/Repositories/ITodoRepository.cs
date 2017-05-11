using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplication.Entities;

namespace WebAPIApplication.Repositories
{
   public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAll();
        
        TodoItem Get(int id);

        void Save(TodoItem TodoItem);

        void Delete(TodoItem id);
        
        void Update(TodoItem TodoItem);
    }
}
