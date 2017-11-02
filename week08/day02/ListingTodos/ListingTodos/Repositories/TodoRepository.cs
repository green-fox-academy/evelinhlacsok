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

        public void AddTask(string todo, int isurgent)
        {
            var newTask = new Todo { Title = todo, IsUrgent = false, IsDone = false};
            if (isurgent == 1)
            {
                newTask.IsUrgent = true;
            }

            TodoContext.Todos.Add(newTask);
            TodoContext.SaveChanges();
        }

        public List<Todo> ListTasks()
        {
            return TodoContext.Todos.ToList();
        }

        public Todo Updating(int id)
        {
            return TodoContext.Todos.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todo todo)
        {
            TodoContext.Todos.Update(todo);
            TodoContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var todotoDelete = TodoContext.Todos.FirstOrDefault(t=>t.Id == id);
            TodoContext.Todos.Remove(todotoDelete);
            TodoContext.SaveChanges();
        }
    }
}
