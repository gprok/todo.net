using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            var email = HttpContext.Session.GetString("email");
            if(email == null)
            {
                return RedirectToAction("Login", "Account");
            }

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


        public IActionResult ImageForm()
        {
           

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UploadImages(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var fileName = Path.GetFileName(formFile.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images/uploads", formFile.FileName);

                    filePaths.Add(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePaths });
        }


        public ActionResult DisplayImages()
        {

            var folderPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images/uploads");

            ViewBag.sourceDir = "/Users/gprok/Projects/testmysql/testmysql/wwwroot/images/uploads";

            ViewBag.Images = Directory.EnumerateFiles(folderPath)
                    .Select(filename => Path.GetFileName(filename));
         
            return View();
        }


    }
}
