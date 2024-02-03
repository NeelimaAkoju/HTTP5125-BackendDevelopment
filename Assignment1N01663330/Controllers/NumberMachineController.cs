using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1N01663330.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives an integer input and performs the following operations
        /// 1.Add 7
        /// 2.Subtract 2
        /// 3.Multiply by 15
        /// 4.Multiply by 3
        /// </summary>
        /// <param name="InputValue"></param>
        /// <returns>The value after the 4 operations</returns>
        /// <example>
        /// GET api/NumberMachine/-3 -> 10
        /// </example>
        /// <example>
        /// GET api/NumberMachine/10 -> 75
        /// </example>
        /// <example>
        /// GET api/NumberMachine/30 -> 175
        /// </example>
        public int Get(int InputValue)
        {
            ///brackets added for visualization of steps as well as for correct BEDMAS operation.
            InputValue = InputValue + 7;
            InputValue = InputValue - 2;
            InputValue = InputValue * 15;
            int FinalOutput = InputValue / 3;
            return FinalOutput;
        }
    }
}
