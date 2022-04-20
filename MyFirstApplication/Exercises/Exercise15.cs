namespace MyFirstApplication;

/*
 This class covers the content for Exercise15
 */

/*
1. Above the class, write an enum called Favorite Movies. Add your own
favorite movies to the enum. Write a method that has a string return type
and an enum parameter. This enum parameter will be your favorite movie
enum. Write a switch expression that takes the enum and prints out a
string return. Use string interpolation in your return message that includes
the name of the movie chosen.
 */

public enum FavoriteMovies { Wreck_It_Ralph, The_Grand_Budapest_Hotel, Dodgeball }
internal class Exercise15
{
    public string BestMovies(FavoriteMovies movieName)
    {
        string movie = movieName switch
        {
            FavoriteMovies.Wreck_It_Ralph => $"My favorite movie is {FavoriteMovies.Wreck_It_Ralph}",
            FavoriteMovies.The_Grand_Budapest_Hotel => $"My favorite movie is {FavoriteMovies.The_Grand_Budapest_Hotel}",
            _ => $"My favorite movie is {FavoriteMovies.Dodgeball}"
        };
        return movie;
    }

    /*
    2. Write a method that takes an enum parameter. This enum will be your
    favorite movie enum. The method will have a tuple return type (int num,
    string movie). Using an explicit int cast on one of your enum, assign the
    value to an int variable. Create second variable of type string. Assign the
    same enum value you used and use the ToString() at the end of it. Return
    both variables as a tuple. See example below for clarity.
    a. Int value = (int)Enum.Value;
    b. string something = Enum.Value.ToString();
     */
    public (int num, string movie) GreatestMovies(FavoriteMovies movie)
    {
        int value = (int)movie;
        string name = movie.ToString();
        return (value, name);
    }

}
