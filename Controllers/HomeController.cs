using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumerosPrimos.Models;

namespace NumerosPrimos.Controllers
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

        [HttpPost]    
        public ActionResult Index(ListNumberPrime model, string command) {    
            
            

            
            var vm = new ListNumberPrime();
            vm.NumberPrimes = new List<NumberPrime>();
        
           if (command == "Comprobar") {   
           
                int numberDivider = 2;
                int resto = 0;
                bool isNumberPrime=true;
                while (numberDivider < model.numberEntered)
                {
                    resto = model.numberEntered % numberDivider;
                    if(resto == 0)
                    {
                        isNumberPrime=false;
                        //return false;
                    }
                    vm.NumberPrimes.Add(new NumberPrime { numberEntered = model.numberEntered, numberDivider = numberDivider, result = model.numberEntered % numberDivider });

                    numberDivider = numberDivider + 1;
                }
                
                  ViewBag.isNumberPrime= isNumberPrime;
                  ViewBag.showList= true;
           
            } 
            
           return View(vm);
                
        }

        public IActionResult Privacy()
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
