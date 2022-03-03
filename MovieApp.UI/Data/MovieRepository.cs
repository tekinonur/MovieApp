using MovieApp.UI.Models;

namespace MovieApp.UI.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>(){
                new Movie()
                {
                    Id= 1,
                    Name ="Shazam",
                    ShortDescription ="Shazam",
                    Description ="<p>Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p><p> totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est</p>",
                    ImageUrl ="1.jpg",
                    CategoryID = 1
                },
                new Movie()
                {
                    Id= 2,
                    Name ="Amazing Grace",
                    ShortDescription ="Amazing Grace",
                    Description ="<p>Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p><p> totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est</p>",
                    ImageUrl ="2.jpg",
                    CategoryID = 2
                },
                new Movie()
                {
                    Id= 3,
                    Name ="High Life",
                    ShortDescription ="High Life",
                    Description ="<p>Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p><p> totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est</p>",
                    ImageUrl ="3.jpg",
                    CategoryID = 3
                },
                new Movie()
                {
                    Id= 4,
                    Name ="Billboard",
                    ShortDescription ="Billboard",
                    Description ="<p>Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p><p> totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est</p>",
                    ImageUrl ="4.jpg",
                    CategoryID = 2
                },
                new Movie()
                {
                    Id= 5,
                    Name ="Storm Boy",
                    ShortDescription ="Storm Boy",
                    Description ="<p>Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p><p> totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est</p>",
                    ImageUrl ="5.jpg",
                    CategoryID = 1
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }
    }
}