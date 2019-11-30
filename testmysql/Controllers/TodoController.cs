using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testmysql.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testmysql.Controllers
{
    public class TodoController : Controller
    {
        // GET: /todo/
        public IActionResult Index()
        {
            TodoDB db = new TodoDB();

            var list = db.taskEntity.ToList();

            ViewBag.TaskList = list;

            return View();
        }

        // GET: /todo/test/
        public IActionResult Test()
        {
            TodoDB db = new TodoDB();

            var list = db.taskEntity.ToList();
            foreach (var t in list)
            {
                Console.WriteLine(t.description);
            }

            ViewData["TaskList"] = list;

            return View();
        }

        // GET: /todo/empty/
        public IActionResult Empty()
        {
            ViewData["Title"] = "Empty Page";

            return View();
        }

        // POST: /todo/add/
        [HttpPost]
        public IActionResult Add(string newTask)
        {
            TodoDB db = new TodoDB();
            Models.Task task = new Models.Task();
            task.description = newTask;
            db.taskEntity.Add(task);
            db.SaveChanges();

            return RedirectToAction("Index");
            // return Content($"Hello {newTask}");
        }


        [HttpGet("/todo/delete/{id}")]
        public IActionResult Delete(long id)
        {
            TodoDB db = new TodoDB();
            Models.Task task = db.taskEntity.Find(id);
            db.taskEntity.Remove(task);
           
            db.SaveChanges();

            return RedirectToAction("Index"); 
        }
    }
}
