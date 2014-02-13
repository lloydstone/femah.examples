using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SomeApplication.Core;

namespace SomeApplication.Web.Controllers
{
    public class AddController : ApiController
    {
        /// <summary>
        /// An Arithmetic class to perform arithmetic functionality.
        /// </summary>
        Arithmetic arithmetic = new Arithmetic();

        // GET api/add/1/2
        /// <summary>
        /// Adds two numbers together and returns the result.
        /// </summary>
        /// <param name="firstNumber">The first number to add</param>
        /// <param name="secondNumber">The second number to add</param>
        /// <returns>The sum of the two given numbers</returns>
        public int Get(int firstNumber, int secondNumber)
        {
            var sum = arithmetic.Add(firstNumber, secondNumber);
            
            return sum;
        }
    }
}
