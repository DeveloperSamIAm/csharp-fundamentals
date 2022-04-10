namespace MyFirstApplication;

/*
This class covers the content for Exercise8
*/
internal class Exercise8
{
    /*
    1. Write a constants at the class level. The constant should be Foot with a 
    value of 12 to represent the number of inches in a foot. Write a method 
    that takes 1 int parameter and a void return type. This method will convert 
    feet to inches. The formula that you would use will be the parameter * 
    Foot. Your parameter will represent the number of feet to convert to 
    inches. Using a Console WriteLine statement, print the results. Test your 
    method using the number 3 to see if you get 36.
     */

    public const int Foot = 12; // inches in foot

    public void FeetToInches(int parameter)
    {
        int total = parameter * Foot;
        Console.WriteLine(total);
    }

    /*
    2. Write a static method that take 2 int parameters and a void return type.
    This method will be used to calculate the length and width of a 
    rectangle/square. This formula is length x width. The first parameter
    should represent the length and the second parameter should be the 
    width. Using a Console WriteLine statement, print the results. Test your 
    method and add what you used to test as a comment either before the 
    method or after.
     */

    public static void CalcLengthWidth(int length, int width)
    {
        int total = length * width;
        Console.WriteLine(total);
    }

    /*
     This is what I used to test in program.cs:

    void Exercise8Example()
    {
    Exercise8.CalcLengthWidth(2, 3);
    }
     */


}
