using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N00982995_Assignment_1_w2022.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// return the string "Hello World!" on Command prompt
        /// </summary>
        /// <param> string "Hello World!"</param>
        /// <returns>"Hello World!</returns>
        /// example
        /// Enter curl -d "" http://localhost:...../api/Greeting
        /// on Command prompt will display "Hello World!"
        public string Post()
        {
            return "Hello World!";
        }
        /// <summary>
        /// returns the string concatenate to input integer 
        /// </summary>
        /// <param name="id">the input number</param>
        /// <return>String with int added to it</return>
        /// example
        /// Enter the number 3
        /// GET api/Greeting/3
        /// the output will be Greetings to 3 people!
        public string Get(int id) 
        {
            return "Greetings to " + id + " people!";
        }
    }
}
