namespace W5_IMDBList;

public class Movie
{
    public string Title { get; set; }
    public double Rating { get; set; }
    
    public Movie(string title, double rating)
    {
        Title = title;
        Rating = rating;
    }
    
    // displaying all movies
    public static void DisplayAllMovies(List<Movie> movieList)
    {
        foreach (var movie in movieList)
        {
            Console.WriteLine($"Title: {movie.Title} | Rating: {movie.Rating}");
        }
    }
    
    // displaying movies rated between 4 and 9
    public static void DisplayGoodMovies(List<Movie> movieList)
    {
        foreach (var movie in movieList)
        {
            if (movie.Rating >= 4 && movie.Rating <= 9)
            {
                Console.WriteLine($"Title: {movie.Title} | Rating: {movie.Rating}");
            }
        }
    }
    
    // displaying movies with title starting with "A"
    public static void DisplayMoviesStartingWithA(List<Movie> movieList)
    {
        foreach (var movie in movieList)
        {
            if (movie.Title.StartsWith("A") || movie.Title.StartsWith("a"))
            {
                Console.WriteLine($"Title: {movie.Title} | Rating: {movie.Rating}");
            }
        }
    }
}