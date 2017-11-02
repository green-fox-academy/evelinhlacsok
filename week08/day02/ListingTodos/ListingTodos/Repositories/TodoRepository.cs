﻿using System;
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

        public void AddTask(string todo)
        {
            //   TodoContext.Todos.Add(new Todo { Title = todo, IsUrgent = true, IsDone = false });
            var newTask = new Todo { Title = todo, IsUrgent = true, IsDone = true };
            TodoContext.Todos.Add(newTask);
            TodoContext.SaveChanges();
        }

        public List<Todo> ListTasks()
        {
            return TodoContext.Todos.ToList();
        }

    }
}
