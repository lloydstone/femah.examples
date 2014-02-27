using Femah.Examples.Additionator.Core;
using Femah.Examples.Additionator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Femah.Examples.Additionator.Web.Controllers
{
    public class ArithmeticController : Controller
    {
        /// <summary>
        /// An Arithmetic class to perform arithmetic functionality.
        /// </summary>
        Arithmetic arithmetic = new Arithmetic();

        /// <summary>
        /// Redirects the user to the home page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return RedirectToAction("index", "home");
        }

        /// <summary>
        /// Adds two numbers together and displays the result.
        /// </summary>
        /// <param name="firstNumber">The first number to add</param>
        /// <param name="secondNumber">The second number to add</param>
        /// <returns>A view containing the sum of the two provided numbers.</returns>
        public ActionResult Add( int firstNumber, int secondNumber)
        {
            var sum = arithmetic.Add(firstNumber, secondNumber);
            
            var model = new AddViewModel { 
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                Sum = sum
            };

            return View(model);
        }
	}
}