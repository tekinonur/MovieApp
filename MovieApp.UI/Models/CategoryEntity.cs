using System;
using System.Collections.Generic;

namespace MovieApp.UI.Models
{
    public partial class CategoryEntity
    {
        public CategoryEntity()
        {
            MovieEntities = new HashSet<MovieEntity>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<MovieEntity> MovieEntities { get; set; }
    }
}
