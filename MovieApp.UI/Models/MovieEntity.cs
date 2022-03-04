using System;
using System.Collections.Generic;

namespace MovieApp.UI.Models
{
    public partial class MovieEntity
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public long CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; } = null!;
    }
}
