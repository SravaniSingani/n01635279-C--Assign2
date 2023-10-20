using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_C__Assign2.Controllers
{
    // J1: Deliv-e-droid
    public class DelivedroidController : ApiController
    {
        /// <summary> 
        /// J1 Problem: Deliv-e-droid (2023)
        /// The 'delivedroid' delivers packages and gains points for each delivery.
        /// For every delivery it gains 50 points.
        /// For each collision it loses 10 points.
        /// If the number of successful deliveries is greater than the collisions,
        /// there is an additional 500 points.
        /// </summary>
        /// 
        /// <param name="deliver"> number of successful deliveries (non-negative integer) </param>
        /// <param name="collide"> number of collisions (non-negative integer)</param>
        /// 
        /// <returns> The output is the total number of points gained
        /// GET : api/delivedroid/points/5/2 -> 730
        /// GET : api/delivedroid/points/0/10 -> -100
        /// </returns>


        [Route("api/delivedroid/points/{deliver}/{collide}")]
        [HttpGet]
        public int Points(int deliver,int collide)
        {
            int addpoints = 500;
            int result;
            int gain;
            int lose;
           

            gain = deliver * 50;
            lose = collide * 10;

            if (deliver > collide)
            {
                result = (gain - lose) + addpoints;
               
            }
            else
            {
                result = gain - lose;
               
            }
            return result;
        }
    }
}
