using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_mvc_crud.Models;
namespace webapi_mvc_crud.Controllers
{
    public class empController : ApiController
    {
        webapitestEntities we = new webapitestEntities();
        [Route("api/getemp")]
        public IHttpActionResult getemp()
        {
            
          var result=  we.newempregs.ToList();
            return Ok(result);
        }
        [HttpPost]
        [Route("api/empinsert")]
        public IHttpActionResult empinsert(newempreg ne)
        {
            we.newempregs.Add(ne);
            we.SaveChanges();
            return Ok();
        }
    }
}
