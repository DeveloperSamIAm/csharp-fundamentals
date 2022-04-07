
namespace MyFirstApplication;

public class Exercise4
{
    /*
    1. Write a method that takes 2 string arguments and a void return type. 
    Using an if-else statement, compare the two strings to each other. Using a 
    Console WriteLine statement, print out the results of whether the strings 
    are equal. Provide a comment inside the method that says what strings 
    you used during testing
     */
    public void Exercise4Method1(string arg1, string arg2)
    {
        Console.WriteLine("Before if statement");
        if (arg1 == arg2)
        {
            Console.WriteLine($"{arg1} and {arg2} are the same");
        }
        else
        {
            Console.WriteLine($"{arg1} and {arg2} are not the same.");
        }

    } /*
      When arg1 = cupcake and arg2 = poptart only the "Before if statement" line
      printed and the "cupcake and poptart are not the same" lines printed.

      When arg1 = cupcake and arg2 = cupcake both the "Before if statement" line
      and the "cupcake and cupcake are the same" lines printed.
      */

    /*
    2. Write a method that will take 1 char argument and a string return type. 
    Using a switch and the table below, return the description. If the value 
    does not match the grade, return the default message, “Not a valid grade”.
    Grade Description
    E Excellent
    V Very Good
    G Good
    A Average
    F Fail
     */

    public string Exercise4Method2(char arg)
    {
        switch(arg)
        {
            case 'E' or 'e':
                return ("Excellent");
            case 'V' or 'v':
                return ("Very Good");
            case 'G' or 'g':
                return ("Good");
            case 'A' or 'a':
                return ("Average");
            case 'F' or 'f':
                return ("Fail");
            default:
                return ("Not a valid grade");
        }
    }

    /*
    3. Write a method that takes no arguments and a void return type. Using an 
    iteration statement, display all the numbers divisible by 3 from 0 to 30. 
    Utilize a modulus to obtain your results
     */
    public void Exercise4Method3()
    {
       for(int i = 0; i < 31; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

} // end class
