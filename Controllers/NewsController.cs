using mvcDemo03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace mvcDemo03.Controllers
{
    public class NewsController : ApiController
    {
        // GET api/values/5
        public string Get(int id)
        {
            return "value:"+id;
        }

        // GET api/values/5
        public News GetNews()
        {
            News news = new News() { Id = 10, Content = "hello",Title="this is title" };
            return news;
        }
    }
}
