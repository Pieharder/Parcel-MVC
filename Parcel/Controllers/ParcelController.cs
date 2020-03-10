using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcel/new")]
    public ActionResult Parcel()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Item myItem = new Item(length, width, height, weight);
      myItem.Price();
      return RedirectToAction("Index");
    }
  }
}