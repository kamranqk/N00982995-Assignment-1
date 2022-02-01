using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_1_w2022.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Number machine takes a number does four 
        /// mathematical operations to it and returns
        /// the number in the end
        /// </summary>
        /// <param name="id"> the input number</param>
        /// <returns> the result after four mathematical operations</returns>
        /// example
        /// Get  api/NumberMachine/10
        ///  10 multipy by 5
        ///  the result divided by 2
        ///  then 1 is added to the result
        ///  finally subtracts 0 from the result
        ///  
        ///  output -> 26
        ///  any decimals will NOT output
        public int GET(int id)
        {
            int multi = id * 5;
            int divi = multi / 2;
            int addi = divi + 1;
            int subt = addi - 0;

            int product = subt;

            return product;
        }


    }
}
