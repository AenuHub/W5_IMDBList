using W5_IMDBList;

public class Program
{
    public static void Main(string[] args)
    {
        // simple bool check for loop
        bool ShouldContinue = true;
        
        List<Movie> movieList = new List<Movie>();
        do
        {
            Console.Write("Enter movie title: ");
            string title = Console.ReadLine();
            Console.Write("Enter rating: ");
            double rating = double.Parse(Console.ReadLine());
            movieList.Add(new Movie(title, rating));

            Console.WriteLine("------------------------------");
            Console.Write("Press 'N' to quit or any other key to enter another movie: ");
            string input = Console.ReadLine();
            Console.WriteLine("------------------------------");
            if (input == "n" || input == "N")
            {
                ShouldContinue = false;
            }
        } while (ShouldContinue);
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("All movies: ");
        Movie.DisplayAllMovies(movieList);
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Movies rated between 4 and 9: ");
        Movie.DisplayGoodMovies(movieList);

        Console.WriteLine("------------------------------");
        Console.WriteLine("Movies with title starting with 'A': ");
        Movie.DisplayMoviesStartingWithA(movieList);
        
        Console.ReadKey();
    }
}