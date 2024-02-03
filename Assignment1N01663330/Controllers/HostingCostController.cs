using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1N01663330.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Receives an integer representing the number of days the user started web hosting. 
        /// This API Call is responsible for calculating the price that it will cost for those days. It uses Fortnights
        /// Based on the input number of days, will calculate the total price based on fortnights charges(1FortNight = 14days) and HST
        /// </summary>
        /// <param name="NoOfDays"></param>
        /// <returns>The price before tax, the dollar amount of tax and the total cost.</returns>
        /// <example>
        /// GET api/HostingCost/0 -> 
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD”
        /// “Total = $6.22 CAD"
        /// </example>
        /// <example>
        /// GET api/HostingCost/15 -> 
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD"
        /// </example>
        /// <example>
        /// GET api/HostingCost/28 -> 
        /// “1 fortnights at $5.50/FN = $16.50 CAD”
        /// “HST 13% = $2.14 CAD”
        /// “Total = $18.64 CAD"
        /// </example>
        public IEnumerable<string> Get(int NoOfDays)
        {
            //calculate number of fortnights
            int FortNights = (NoOfDays / 14) + 1;

            //calculate total cost before taxes
            double BeforeTax = FortNights * 5.5;

            //calculate cost of HST
            double HST = BeforeTax * .13;

            //calculate total cost for the client
            double Total = BeforeTax + HST;

            string[] TotalResponse = {FortNights.ToString() + " fortnights at $5.50/FN = $" + BeforeTax.ToString("0.00") + " CAD",
                        "HST 13% = $" + HST.ToString("0.00") + " CAD",
                        "Total = $" + Total.ToString("0.00") + " CAD"};


            return TotalResponse;
        }
    }
}
