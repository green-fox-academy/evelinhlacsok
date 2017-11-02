using System;
using ListingTodos.Entities;
using System.Collections.Generic;
using System.Linq;
using ListingTodos.Models;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTask()
        {
            
        }

        public List<Todo> ListTasks()
        {
            return TodoContext.Todos.ToList();
        }

    }
}
