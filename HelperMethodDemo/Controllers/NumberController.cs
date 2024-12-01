using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethodDemo.Models;

namespace HelperMethodDemo.Controllers
{
    public class NumberController : Controller
    {
        // GET: Number
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MultiNumberModel()
        {
            return View(new Operation());
        }
        [HttpPost]
        public ActionResult PerformModel(Operation operation)
        {
            switch (operation.Opr)
            {
                case "1":
                    if (operation.IsFloating)
                        ViewBag.Ans = "Addition = " + (Convert.ToSingle(operation.No1) + Convert.ToSingle(operation.No2));
                    else
                        ViewBag.Ans = "Addition = " + (operation.No1 + operation.No2);
                    break;
                case "2":
                    if (operation.IsFloating)
                        ViewBag.Ans = "Subtraction = " + (Convert.ToSingle(operation.No1) - Convert.ToSingle(operation.No2));
                    else
                        ViewBag.Ans = "Subtraction = " + (operation.No1 - operation.No2);
                    break;
                case "3":
                    if (operation.IsFloating)
                        ViewBag.Ans = "Multiplication = " + (Convert.ToSingle(operation.No1) * Convert.ToSingle(operation.No2));
                    else
                        ViewBag.Ans = "Multiplication = " + (operation.No1 * operation.No2);
                    break;
                case "4":
                    if (operation.IsFloating)
                        ViewBag.Ans = "Division = " + (Convert.ToSingle(operation.No1) / Convert.ToSingle(operation.No2));
                    else
                        ViewBag.Ans = "Division = " + (operation.No1 / operation.No2);
                    break;
                default:
                    ViewBag.Ans = "Invalid Operation";
                    break;

            }
            return View("MultiNumberModel",operation);
        }
    }
}