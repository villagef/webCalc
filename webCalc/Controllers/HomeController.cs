using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CalculatorDll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webCalc.Models;

namespace webCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(Operation model)
        {
            var factory = new CalcFactory();
            var operation = factory.GetOperation(model.OperationType);
            model.Result = operation.MathOperation(model.NumberA, model.NumberB);

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
