// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using CarDealership.Models;

// namespace CarDealership.Controllers
// {
//   public class CarsController : Controller
//   {
    
//     [HttpGet("/cars/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }

//     [HttpPost("/cars")]
//     public ActionResult Create(string makeModel, int price, int miles)
//     {
//       Car myItem = new Car(makeModel, price, miles);
//       return RedirectToAction("Index");
//     }

//   }
// }