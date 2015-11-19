using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hack.Spoofing.Service.Controllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult Post(string user, string password, string origin)
        {
            //pegar ip
            return Ok();
        }
    }
}
