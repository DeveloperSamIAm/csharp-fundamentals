namespace MyFirstApplication;

    public class Exercise2
{
    /*
     1. Write a method that takes a string argument parameter and void return 
    type. Using string concatenation and the below string methods, write a 
    Console WriteLine statement for each of them. Inside the string 
    concatenation will be the name of each string method. When testing this 
    method use the following string “ EXERCISE two Lab “. Do not copy and 
    paste this in Visual Studio. It will not paste correctly.
    a. Trim()
    b. ToLower()
    c. Contains(“tow”)
    d. Length()
    e. IndexOf(‘C’)
     */
    public void Exercise2Method1(string phrase)
    {
        Console.WriteLine("Trim() = " + phrase.Trim());
        Console.WriteLine("ToLower() = " + phrase.ToLower());
        Console.WriteLine("Contains() = " + phrase.Contains("tow"));
        Console.WriteLine("Length = " + phrase.Length);
        Console.WriteLine("IndexOf = " + phrase.IndexOf('C'));
    }


    /*
    2. Write a method that takes no arguments and a void return type. Using the 
    Unicode table resource link, assign the Unicode value of the Pilcrow Sign to 
    a variable. Use the Console WriteLine to print that variable. This variable 
    should utilize the type that takes 1 character
     */
    public void Exercise2Method2()
    {
        char myChar = '\u00B6';
        Console.WriteLine(myChar);
    }


    /*
     3. Write a method that takes no arguments and a void return type. Use 1 
    string variable and 1 Console WriteLine to complete this task. Use escape 
    sequences to achieve the below results.
    Output:
    Jack and Jill
    went up the hill
    to fetch a pail of water.
    Jack fell down and broke his crown
    and Jill came tumbling after.
     */

    public void Exercise2Method3()
    {
        string phrase = "Jack and Jill \nwent up the hill \nto fetch a pail of water.\n" +
            "Jack fell down and boke his crown \nand Jill came tumbling after.";
        Console.WriteLine(phrase);
    }


    /*
    4. Write a method that takes no arguments but does have a string return 
    type. You will utilize Interpolation to complete this task. Create variables
    for each provided data below. Using Interpolation return a string that 
    includes the variables in a sentence.
    a. Name
    b. Favorite movie
    c. Favorite movie snack
    d. Favorite movie drink
     */

    public string Exercise2Method4()
    {
        string name = "Sami King";
        string movie = "The Grand Budapest Hotel";
        string snack = "sour chewy sprees";
        string drink = "coke vanilla";
        return $"My name is {name}, and I am going to see {movie} with {snack} and a {drink}.";
    }

} // end class
