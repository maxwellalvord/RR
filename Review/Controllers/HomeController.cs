using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }

    }
}

// using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;

// namespace ToDoList.Controllers
// {
//   public class HomeController : Controller
//   {

//     [Route("/")]
//     public ActionResult Index()
//     {
//       Item starterItem = new Item("Add first item to To Do List");
//       return View(starterItem);
//     }

//   }
// }