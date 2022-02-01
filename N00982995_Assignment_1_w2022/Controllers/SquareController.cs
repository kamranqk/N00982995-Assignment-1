using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_1_w2022.Controllers
{
    /// <summary>
    /// Returns the input multiplied by itself
    /// </summary>
    /// <parm> name = id> The input number</parm>
    /// <return> The input multiplied by itself</return>
    /// example
    /// GET /api/Square/2 -> 4
    public class SquareController : ApiController
    {
        public int GET(int id)
        {
            return id * id;
        }
    }
}
