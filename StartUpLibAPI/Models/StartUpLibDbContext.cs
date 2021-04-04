using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUpLibAPI.Models
{
    public class StartUpLibDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public StartUpLibDbContext(DbContextOptions<StartUpLibDbContext> options)
            : base(options) {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
