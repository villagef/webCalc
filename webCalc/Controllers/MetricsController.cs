using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorDll;
using Microsoft.AspNetCore.Mvc;
using webCalc.Models;

namespace webCalc.Controllers
{
    public class MetricsController : Controller
    {
        [HttpPost]
        public IActionResult Length(Metric model)
        {
            var length = new MetricsLength();

            var newModel = new Metric();

            if (model.Cm == null)
            {
                newModel.Cm = Math.Round(length.ConvertInchesToCm((double)model.Inches), 2);
            }
            else if (model.Inches == null)
            {
                newModel.Cm = Math.Round(length.ConvertCmToInches((double)model.Cm), 2);
            }
            else
            {
                newModel.Cm = Math.Round(length.ConvertInchesToCm((double)model.Inches), 2);
                newModel.Inches = Math.Round(length.ConvertCmToInches((double)model.Cm), 2);
            }

            return View("Index", newModel);
        }

        [HttpPost]
        public IActionResult Distance(Metric model)
        {
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Temperature(Metric model)
        {
            return View("Index", model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}