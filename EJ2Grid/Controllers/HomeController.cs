using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2Grid.Models;
using Syncfusion.EJ2.Base;
using Syncfusion.EJ2.Navigations;
using System.Collections;

namespace EJ2Grid.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      ViewBag.Data = OrdersDetails.GetAllRecords();
      // Here you can assign values based on the user role
      ViewBag.gridAdd = false;
      ViewBag.gridEdit = true;
      ViewBag.gridDelete = false;
      ViewBag.EmplIDVisibility = false;
      ViewBag.EmplIDEdit = false;
      ViewBag.CustomerIDVisibility = true;
      ViewBag.CustomerIDEdit = false;
      ViewBag.ShipCountryVisibility = true;
      ViewBag.ShipCountryEdit = true;
      return View();
    }
  }
}

