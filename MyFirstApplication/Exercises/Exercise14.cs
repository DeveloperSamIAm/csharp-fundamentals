namespace MyFirstApplication;

/*
 This class covers the content for Exercise14
 */

internal class Exercise14
{
    /*
    1. Write a method with no parameters and no return type. Write a single
    dimensional string array of ice cream flavors. Using a foreach loop in your
    method, print out the results of your array using a Console WriteLine
    statement.
    */
    public void IceCreamFlavors()
    {
        string[] flavors = { "vanilla", "mint", "americone dream", "cookie dough", "matcha" };

        foreach(string flavor in flavors)
        {
            Console.WriteLine(flavor);
        }
    }

    /*
    2. Write a method with no parameters and no return type. Write a twodimensional 
    array using the int data type. Using the link below, fill in each
    dimension with the KC Chiefs Regular season scores. The first dimension
    will be the home team, while the second dimension will be the away team.
    Using a foreach loop, print out the results of your array using a Console
    WriteLine statement. To determine which team is home and away, the
    website includes the link to the box score. The link label shows both teams.
    The first team in the label is the away team.
    a. https://www.footballdb.com/teams/nfl/kansas-citychiefs/results/2020
    */
    public void RegularScores()
    {   
        // Denver Broncos vs Kansas City Chiefs
        int[,] scores = { { 6, 3, 0, 7, 16 }, { 10, 14, 6, 13, 43 } };

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
        
    }

} // end class
