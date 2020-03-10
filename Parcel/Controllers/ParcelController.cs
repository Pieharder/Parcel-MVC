using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcels/new")]
    public ActionResult JobForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string title, string description, string contact)
    {
      Item myItem = new Item(title, description, contact);
      return RedirectToAction("Index");
    }

  }
}