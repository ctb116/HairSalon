using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    [HttpGet("/clients")]
    public ActionResult Index()
    {
      List<Client> clientList = Client.GetAll();
      return View("Index", clientList);
    }

    [HttpGet("/stylists/{id}/clients/new")]
    public ActionResult CreateForm(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist stylist = Stylist.Find(id);
      return View(stylist);
    }
  }
}
