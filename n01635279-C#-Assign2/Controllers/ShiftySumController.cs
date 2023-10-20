using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_C__Assign2.Controllers
{
    public class ShiftySumController : ApiController
    {

        /// <summary>
        /// J2 Problem: Shifty Sum (2017)
        /// The shifty takes a positive integer as an input and shift value (non-negative integer).
        /// For every shift, 0 is added at the end of the input digit. (say for input 12 -> 120,1200 and so on)
        /// The output is the sum of all the digits acquired after the shifts.
        /// </summary>
        /// 
        /// <param name="num"> the number N (1 ≤ N ≤ 10000) </param>
        /// <param name="shifts"> the number of times to shift N (0 ≤ k ≤ 5) </param>
        /// 
        /// <returns> Output is an integer which is the shifty sum of N by k
        /// GET : api/shiftysum/getshift/12/3  -> 13332
        /// </returns>

        [Route("api/shiftysum/getshift/{num}/{shifts}")]
        [HttpGet]
        public int GetShift(int num, int shifts)
        {
            
            int result = 0;
            int value = num;
            int n = shifts;
            int power;

            for (int i = 0; i <= n; i++)
            {
                power = (int)Math.Pow(10, i);
                result = result + (value * power);
            }

            return result;

        }
    }
}
