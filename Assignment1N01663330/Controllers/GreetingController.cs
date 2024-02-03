using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1N01663330.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Post request which returns "Hello World!"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST api/Greeting -> "Hello World!"
        /// </example>
        /// <example>
        /// POST api/Greeting/"anything" -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Receives input that represents the number of people and Greets with message.
        /// </summary>
        /// <param name="id">Number of people</param>
        /// <returns>A greeting to the number of people entered </returns>
        /// <example>
        /// GET api/Greeting/3 -> "Greetings to 3 people!"
        /// </example>
        /// <example>
        /// GET api/Greeting/7 -> "Greetings to 7 people!"
        /// </example>
        /// <example>
        /// GET api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get(string NumberOfPeople)
        {
            return "Greetings to " + NumberOfPeople + " people!";
        }
    }
}
