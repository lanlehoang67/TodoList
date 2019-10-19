using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models.Entities
{
    public class TodoModel
    {
        List<TodoItem> todos;
        public TodoModel()
        {
            todos = new List<TodoItem>();
            todos.Add(new TodoItem(1, "Cooking", true));
            todos.Add(new TodoItem(2, "Reading", true));
            todos.Add(new TodoItem(3, "Learning", true));

        }
        public List<TodoItem> GetTodos(){
            return todos;
        }
        public void AddNewTodoItem(int id, string Name, bool isCompleted){
            todos.Add(new TodoItem(id, Name, isCompleted));
        }
        public void DeleteTodoItem(int id){
            TodoItem item = GetTodoItem(id);
            todos.Remove(item);
        }
        public void UpdateTodoItem(int id, string Name, bool isCompleted){
            TodoItem item = GetTodoItem(id);
            item.Name = Name;
            item.IsCompleted = isCompleted;    
        }
        public TodoItem GetTodoItem(int id){
            TodoItem item = todos[id -1];
            return item;
        }
    }
    
}