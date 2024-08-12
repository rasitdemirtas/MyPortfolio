using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using MyPortolio.DAL.Entites;
using NuGet.Protocol;

namespace MyPortolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context =new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
         var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value=context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList todoList)
        {
            context.ToDoLists.Update(todoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListToTrue(int id)
        {
            var value =context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
