using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Femah.Examples.Additionator.Web.Models
{
    /// <summary>
    /// View model for the Add view.
    /// </summary>
    public class AddViewModel
    {
        /// <summary>
        /// The first number to be added.
        /// </summary>
        public int FirstNumber { get; set; }

        /// <summary>
        /// The second number to be added.
        /// </summary>
        public int SecondNumber { get; set; }

        /// <summary>
        /// The sum of the two numbers.
        /// </summary>
        public int Sum { get; set; }
    }
}