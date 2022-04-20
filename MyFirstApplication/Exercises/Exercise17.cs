namespace MyFirstApplication;

/*
 This class covers the content for Exercise17
 */

internal class Exercise17
{
    /*
    1. Write a method that has two int parameters and no return type. You will
    use a try/catch for this method. Create a division problem in the try block.
    The catch block will utilize the DivideByZeroException. Provide a Console
    WriteLine message for both the try block and the catch block. The one in
    the try block should display the answer to the division problem. The one in
    the catch block should have a message using Interpolation along with a
    variable.Message syntax. Test the method with different numbers,
    including 0 so you can ensure the catch executes. 
     */

    public void Exercise17Method1(int value1, int value2)
    {
        try
        {
            int total = value1 / value2;
            Console.WriteLine($"The total is: {total}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero message was thrown: {ex.Message}");
        }
    }


    /*
    2. Write a method that has a horse parameter and no return type. Using an if
    statement, determine if your horse is null. If it is null, use the throw
    keyword and a message to indicate it is null. If the horse is not null, use a
    Console WriteLine statement to print out one of your horse properties.
     */
    public void Exercise17Method2(Horse horse)
    {
        if(horse == null)
        {
            throw new NullReferenceException("Horse object is null");
        }
        else
        {
            Console.WriteLine($"The horse is not null and is {horse.CoatColor}");
        }
    }

} // end class
