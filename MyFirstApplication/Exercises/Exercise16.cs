namespace MyFirstApplication;

/*
 This class covers the content for Exercise16
 */
internal class Exercise16
{
    /*
    1. Write a method that has no parameters and a no return type. Create a
    List<T> of your Horse objects. When creating your list, utilize all the
    constructors you created with your Horse class. Using a foreach loop, print
    out the results of your collection using a Console WriteLine statement.
     */
    public void HorseList()
    {
        List<Horse> horseList = new List<Horse>();
        horseList.Add(new Horse());
        horseList.Add(new Horse("Tan", 5, "Vinyl"));
        horseList.Add(new Horse("Black", 6, "Plastic"));

        foreach (Horse horse in horseList)
        {
            Console.WriteLine(horse.CoatColor);
            Console.WriteLine(horse.ShoeSize);
            Console.WriteLine(horse.SaddleMaterial);
        }
    }

    /*
    2. Write a method that has no parameters and no return type. Using only the
    data you used when building your favorite movies from exercise 15, create
    a Dictionary collection that takes an int key and string value. When adding
    Dictionary elements, pick an int value as the key and use the favorite
    movies data as the string. Using a foreach loop, print out the results of your
    collection using a Console WriteLine statement.
     */
    public void MovieDictionary()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Wreck It Ralph");
        dictionary.Add(2, "The Grand Budapest Hotel");
        dictionary.Add(3, "Dodgeball");

        foreach(KeyValuePair<int, string> movie in dictionary)
        {
            Console.WriteLine($"Movie Number: {movie.Key}, Movie Name: {movie.Value}");
        }
    }

}
