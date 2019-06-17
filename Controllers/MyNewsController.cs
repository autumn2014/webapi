using mvcDemo03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcDemo03.Controllers
{
    public class MyNewsController : ApiController
    {
        private News[] news = new News[] {
            new News{Id=1,Content="hell0",Title="title"},
            new News{Id=1,Content="hell0",Title="title"},
            new News{Id=1,Content="hell0",Title="title"},
            new News{Id=1,Content="hell0",Title="title"},
            new News{Id=1,Content="hell0",Title="title"}
        };
        public List<News> listNews = new List<News>()
        {
            new News{Id=1,Content="4272",Title="title"},
            new News{Id=1,Content="5785",Title="title"},
            new News{Id=1,Content="45324528",Title="title"}

        };
        //GET: api/News[ResponseType(typeof(IEnumerable<News>))]
        public IEnumerable<News> getAll()
        {
            return news;
        }
        public List<News> getAllNews()
        {
            return listNews;
        }

        //// GET: api/MyNews
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/MyNews/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MyNews
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MyNews/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MyNews/5
        public void Delete(int id)
        {
        }
    }
}
