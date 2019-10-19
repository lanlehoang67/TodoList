using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models.Entities
{
    public class TodoItem
    {
        public int Id {get; set;}
        public string Name { get; set; }   
        public bool IsCompleted { get; set; }
        public TodoItem(int Id, string Name, bool IsCompleted)
        {   
            this.Id = Id;
            this.Name = Name;
            this.IsCompleted = IsCompleted;
        }
    }
}