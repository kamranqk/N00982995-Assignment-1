using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_1_w2022.Controllers
{
    /// <summary>
    /// Return the input number plus 10
    /// </summary>
    /// <parm name = id>The input number</parm>
    /// <return> The input with 10 added</return>
    /// example
    /// GET /api/AddTen/21 -> 31

    public class AddTenController : ApiController
    {
        public int GET(int id)
        {
            return id + 10;
        }
    }

}
