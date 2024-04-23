// See https://aka.ms/new-console-template for more information
using question_3_74536;

Console.WriteLine("Hello, World!");
List<Movie> movies = new List<Movie>()
{
     new Movie("The Shawshank Redemption", "Frank Darabont", Rate.R, 142),
    new Movie("Inception", "Christopher Nolan", Rate.PG13, 148),
    new Movie("The Godfather", "Francis Ford Coppola", Rate.R, 175),

};

foreach(var movie in movies)
{
    movie.toString();
}