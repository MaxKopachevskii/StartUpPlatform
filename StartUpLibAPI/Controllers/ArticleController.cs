using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartUpLibAPI.Models;

namespace StartUpLibAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        StartUpLibDbContext db;
        public ArticleController(StartUpLibDbContext context) {
            db = context;
            if (db.Articles.Count() == 0) {
                ArticleCategory articleCategory1 = new ArticleCategory() {
                    Name = "IT",
                    Desc = "Категория информационных технологий",
                };
                ArticleCategory articleCategory2 = new ArticleCategory() {
                    Name = "Бизнес",
                    Desc = "Категория бизнес задач и целей",
                };
                db.ArticleCategories.AddRange(articleCategory1, articleCategory2);
                db.SaveChanges();

                Article article1 = new Article() {
                    Title = "Искуственный интелект для смартфонов",
                    Base = "Искуственный интелект для смартфонов:)",
                    Description = "Искуственный интелект для смартфонов может стать революционной идеей в сфере технологий и покорить мир:)",
                    Email = "max169666@gmail.com",
                    ArticleCategoryId = articleCategory1.Id
                };

                Article article2 = new Article() {
                    Title = "Кибер кафе",
                    Base = "",
                    Description = "Кафе в котром можно спокойно поработать , некий open-space для программистов фриланса",
                    Email = "max169666@gmail.com",
                    ArticleCategoryId = articleCategory2.Id
                };

                db.Articles.AddRange(article1, article2);
                db.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Article>> Get() {
            var articles = db.Articles.ToList();
            return articles;
        }
    }
}