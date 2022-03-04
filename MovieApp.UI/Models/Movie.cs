namespace MovieApp.UI.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public long CategoryID { get; set; }
    }
}