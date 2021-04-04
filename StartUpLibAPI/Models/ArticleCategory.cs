using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StartUpLibAPI.Models
{
	public class ArticleCategory
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        [JsonIgnore]
        public virtual ICollection<Article> Articles { get; set; }

        public ArticleCategory() {
            Articles = new List<Article>();
        }
    }
}
