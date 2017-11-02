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
            TodoContext.Todos.Add(new Todo() { Title = "feed the dog", IsUrgent = true, IsDone = false});
            TodoContext.Todos.Add(new Todo() { Title = "eat", IsUrgent = true, IsDone = false });
            TodoContext.SaveChanges();
        }

        public List<Todo> ListTasks()
        {
            return TodoContext.Todos.ToList();
        }

    }
}
