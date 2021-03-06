﻿using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _todos = new List<Todo>();
        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo {Id = 1, Title = "ASP.NET Core Ecu", IsDone = false},
                new Todo {Id = 2, Title = "Blazor Ecu", IsDone = false},
                new Todo {Id = 3, Title = "C# Ecu", IsDone = true}
            };
        }

        // In-Memory Database using Area
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }

}
