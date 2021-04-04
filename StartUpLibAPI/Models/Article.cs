using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StartUpLibAPI.Models
{
	public class Article
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Base { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }

		public Guid? ArticleCategoryId { get; set; }

		[JsonIgnore]
		public virtual ArticleCategory ArticleCategory { get; set; }

	}
}
