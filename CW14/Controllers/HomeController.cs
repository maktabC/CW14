using CW14.Database;
using CW14.Models;
using CW14.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW14.Controllers;

public class HomeController : Controller
{
    BookRipository bookRipository=new BookRipository();
    public IActionResult Index()
    {
        return View(bookRipository.GetAllBook());
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveBook(Book book)
    {
        bookRipository.AddBook(book);
        return RedirectToAction("Index");
    }

    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(UpdateDTO book,int id)
    {
        bookRipository.UpdateBook(book,id);
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Delete(int id)
    {
        bookRipository.DeleteBook(id);
        return RedirectToAction("Index");
    }
}
