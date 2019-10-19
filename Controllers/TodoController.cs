using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models.Entities;
using TodoApp.Models;
namespace TodoApp
{
    public class TodoController : Controller
    {
        private TodoModel todoModel;
        public TodoController(){
            todoModel = new TodoModel();
        }
        public IActionResult Index()
        {
            var todos = new List<TodoItem>();
            todos = todoModel.GetTodos();
            return View(todos);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Add(int Id, string Name, bool isCompleted){
            todoModel.AddNewTodoItem(Id, Name, isCompleted);
            return View("index", todoModel.GetTodos());
        }
        public IActionResult Edit(int id){
            TodoItem item = todoModel.GetTodoItem(id);
            return View("Edit",item);
        }
        [HttpPost]
        public IActionResult Update(int id, string Name, bool isCompleted){
            todoModel.UpdateTodoItem(id, Name, isCompleted);
            return View("index", todoModel.GetTodos());
        }
        [HttpPost]
        public IActionResult Delete(int id){
            todoModel.DeleteTodoItem(id);
            return View("index", todoModel.GetTodos());
        }
    }
}