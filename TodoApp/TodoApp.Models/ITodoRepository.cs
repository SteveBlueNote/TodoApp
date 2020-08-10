using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model); // Input Data
        List<Todo> GetAll(); //Output Data
    }

}
