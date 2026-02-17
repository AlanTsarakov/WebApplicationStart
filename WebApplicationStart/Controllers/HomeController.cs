using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 6 && now.Hour >= 0)
            {
                return "Доброй ночи";
            }
            else if (now.Hour >= 6 && now.Hour < 12)
            {
                return "Доброе утро";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                return "Добрый день";
            }
            else
            {
                return "Добрый вечер";
            }
        }

        public int Task2(int n1, int n2)
        {
            return n1 + n2;
        }

        public string Task3(int n1, int n2, string operation)
        {
            if (operation == "+")
            {
                return (n1 + n2).ToString();
            }
            else if (operation == "-")
            {
                return (n1 - n2).ToString();
            }
            else if (operation == "*")
            {
                return (n1 * n2).ToString();
            }
            else
            {
                return "Скорректируйте свой запрос!";
            }
        }

        public string Task4(int a, int b, string c)
        {
            if (c == "-")
            {
                return (a - b).ToString();
            }
            else if (c == "%2B")
            {
                return (a * b).ToString();
            }
            else if (c == "/")
            {
                if (b != 0)
                {
                    return (a / (double)b).ToString();
                }
                else
                {
                    return "На ноль делить нельзя!";
                }
            }
            else if (c == "*")
            {
                return (a * b).ToString();
            }
            else
            {
                if (c == null)
                {
                    return (a + b).ToString();
                }
                return "Скорректируйте запрос!";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}