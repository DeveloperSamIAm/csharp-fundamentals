
namespace MyFirstApplication;

public class Exercise5
{
    /*
    1. Write a method that takes 2 int parameters and an int return type. Using 
    the formula below from Ohm’s law, determine the voltage. The first
    method parameter will represent current and the second parameter will 
    represent resistance. Using the Func<int, int, int> and a lambda 
    expression, determine the voltage calculation and return the value.
    a. Voltage = Current x Resistance
     */
    public int Exercise5Method1(int current, int resistance)
    {
        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        int value = voltage(current, resistance);
        return value;
    }

    /*
    2. Write a method that will take 1 char parameter and a string return type. 
    Using a switch expression and the table below, return the description. If 
    the value does not match the grade, return the default message, “Not a 
    valid grade”.
    Grade Description
    E Excellent
    V Very Good
    G Good
    A Average
    F Fail
     */
    public string Exercise5Method2(char grade)
    {
        string result = grade switch
        {
            'E' or 'e' => "Excellent",
            'V' or 'v' => "Very Good",
            'G' or 'g' => "Good",
            'A' or 'a' => "Average",
            'F' or 'f' => "Fail",
            _ => "Not a valid grade"
        };
        return result;
    }

    /*
    3. Write a method that takes 1 argument and a void return type. Using a
    Relational Pattern and switch expression determine a size of popcorn
    based on the table below and using a Console WriteLine, print the popcorn 
    size.
    Size Size Value
    Less or equal 3 Microwave bag
    Less or equal 16 Movie sack
    Less or equal 32 Movie cup
    Less or equal 64 Movie tub
    Default We don’t have that size
     */
    public void Exercise5Method3(int size)
    {
        string result = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size"
        };
        Console.WriteLine(result);
    }


} // end class