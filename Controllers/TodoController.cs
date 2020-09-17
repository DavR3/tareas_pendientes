using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreTodo.Controllers{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService){
            _todoItemService = todoItemService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}