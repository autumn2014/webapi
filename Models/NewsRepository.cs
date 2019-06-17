﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDemo03.Models
{
    public class NewsRepository
    {
        public IEnumerable<News> GetAllNews()
        {
            News[] news = new News[]
            {
                new News { Id = 1, Title="新闻标题1", Content="新闻内容1", Author="xishuai", CreateTime=DateTime.Now },
                new News { Id = 2, Title="新闻标题2", Content="新闻内容2", Author="xishuai", CreateTime=DateTime.Now },
                new News { Id = 3, Title="新闻标题2", Content="新闻内容3", Author="xishuai", CreateTime=DateTime.Now }
            };
            return news;
        }
    }
}