using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1N01663330.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an integer input,adds 10 to the input.
        /// </summary>
        /// <param name="id">The integer input</param>
        /// <returns>The integer input plus 10</returns>
        /// <example>
        /// GET api/AddTen/2 -> 8
        /// </example>
        /// <example>
        /// GET api/AddTen/-3 -> 7
        /// </example>   
        /// <example>
        /// GET api/AddTen/5 -> 15
        /// </example>
        public int Get(int InputValue)
        {
            return InputValue + 10;
        }
    }
}
