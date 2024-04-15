using System.Collections.Generic;
using System.Reflection.Metadata;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace DevCard.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"مقاله شماره یک","توضیحات مقاله اول","blog-post-thumb-1.jpg") ,
                new Article(2,"مقاله شماره دوم","توضیحات مقاله دوم","blog-post-thumb-2.jpg") ,
                new Article(3,"مقاله شماره سه","توضیحات مقاله سوم","blog-post-thumb-3.jpg") ,
            };

            return View("_Articles",articles);
        }
    }
}