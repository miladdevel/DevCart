
using System.Collections.Generic;
using DevCart_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCart_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش asp.net core mvc", "کاملترین آموزش asp net oore mvc از سایت ما",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش گیت و گیت هاب", "کاملترین آموزش git از سایت ما",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش onion", "کاملترین آموزش onion از سایت ما",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش طراحی سایت", "کاملترین آموزش طراحی سایت از سایت ما",
                    "blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles", articles);
        }

    }
}
