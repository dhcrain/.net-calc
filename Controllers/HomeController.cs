using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace MVCMaby.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string Number1, string Operator, string Number2)
        {
            if (Operator != null)
            {
                float num_1 = float.Parse(Number1);
                float num_2 = float.Parse(Number2);
                double answer;
                switch (Operator) 
                {
                    case "+":
                        answer = num_1 + num_2;
                        break;
                    case "-":
                        answer = num_1 - num_2;
                        break;
                    case "/":
                        if (Number2 == "0")
                        {
                            answer = Double.NaN;
                        }
                        else
                        {
                            answer = num_1 / num_2;
                        }
                        break;
                    case "X":
                        answer = num_1 * num_2;
                        break;
                    default:
                        answer = 0;
                        break;
                }
                Console.WriteLine(answer);
                ViewData["answer"] = Math.Round(answer, 4);
            }
            ViewData["Number1"] = Number1;
            ViewData["Number2"] = Number2;
            ViewData["Operator"] = Operator;
            ViewData["Title"] = "Calculator";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}