using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_C__Assign2.Controllers
{
    public class SumacSequenceController : ApiController
    {

        /// <summary>
        /// J3 Problem: Sumac Sequence (2011)
        /// There are two inputs of positive integers. 
        /// In Sumac Sequence, t1, t2, t3, .., tm  each term is an integer greater than or equal 0.
        /// Each term,starting with the third, is the difference of the preceding two terms
        /// The sequence is terminated when the digit preceeding is lesser than the resulted difference.
        /// The output is the length of the sequence.
        /// </summary>

        /// <example>
        /// If we have 120 and 71, the sequence generated is:
        ///  120, 71, 49, 22, 27   -> result is 5
        /// </example>


        /// <param name="digit1"> A positive integer t1 </param>
        /// <param name="digit2"> A positive integer t2 </param>
        ///  0 < t2 < t1 < 10000.

        /// <returns> Output is the length of the sumac sequence
        /// GET: api/sumacsequence/seqnum/120/71   ->  5
        /// </returns>


        [Route("api/sumacsequence/seqnum/{digit1}/{digit2}")]
        [HttpGet]
        public int SeqNum(int digit1,int digit2)
        {
            int num1 = digit1;
            int num2 = digit2;
            int count = 2;
            int difference;
            while (num1 > num2)
            {
                difference = num1 - num2;
                num1 = num2;
                num2 = difference;
                count++;
            }
            

            return count;
        }
    }
}
