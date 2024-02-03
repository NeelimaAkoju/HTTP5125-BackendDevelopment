using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1N01663330.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Receives an integer input value, returns the square of that input.
        /// </summary>
        /// <param name="InputValue">the integer to square</param>
        /// <returns>the square of integer</returns>
        /// <example>
        /// GET api/Square/2 -> 4
        /// </example>
        /// <example>
        /// GET api/Square/-2 -> 4
        /// </example>   
        /// <example>
        /// GET api/Square/10 -> 100
        /// </example>
        public int Get(int InputValue)
        {
            int AfterSquare = InputValue * InputValue;
            return AfterSquare;
        }
    }
}
