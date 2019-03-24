using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conduit.Domain
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<ArticleTag> ArticleTags { get; set; } = new List<ArticleTag>();
    }
}
