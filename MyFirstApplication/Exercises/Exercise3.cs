
namespace MyFirstApplication;

public class Exercise3
{
    /*
    1. Write a method that takes 1 int argument and an int return type. Utilize
    the modulus operator to complete this task. Assign the data values below 
    to their own variables. Use the Console WriteLine statement on the first 4 
    variables listed below and calculate the modulus with the passed in 
    argument parameter. Using the last variable below, calculate the modulus
    with the passed in argument parameter and return it. 
    a. 15
    b. 456
    c. 23
    d. 89
    e. 245
     */
    public int Exercise3Method1(int value)
    {
        int value1 = 15;
        int value2 = 456;
        int value3 = 23;
        int value4 = 89;
        int value5 = 245;
        Console.WriteLine(value1 % value);
        Console.WriteLine(value2 % value);
        Console.WriteLine(value3 % value);
        Console.WriteLine(value4 % value);
        return (value5 % value);
    }


    /*
    2. Write a method that takes no arguments and a void return type. Utilizing 
    the math problem in this task, fill in any missing pieces to get the output.
    10 + 32 * 12 / 3. Write a Console WriteLine to solve each output.
    a. Output: 138
    b. Output: 168
    c. Output: 131
     */
    public void Exercise3Method2()
    {
        Console.WriteLine(10 + (32 * 12) / 3);
        Console.WriteLine((10 + 32) * (12 / 3));
        Console.WriteLine((10 + (32 * 12)) / 3);
    }

    /*
    3. Write a method that takes two short type arguments and a void return 
    type. Using the Compound Assignment operators below, use the first 
    argument parameter as the left operand to get the result. Print each one 
    using the Console WriteLine statement.
    a. +=
    b. /=
    c. *=
    d. %=
    */
    public void Exercise3Method3(short arg1, short arg2)
    {
        Console.WriteLine(arg1 += arg2);
        Console.WriteLine(arg1 /= arg2);
        Console.WriteLine(arg1 *= arg2);
        Console.WriteLine(arg1 %= arg2);
    }


    /*
    4. Write a method that takes two bool type arguments and a void return 
    type. Using Boolean Logical operators &, |, ^, and || to complete this task.
    Use a Console WriteLine statement to calculate each result using the 
    operators. The second argument is the left operand. Use the below values 
    when testing your method. Using comments, provide your output results
    inside the method after your statements.
    a. Argument1 = true, Argument2 = false
    b. Argument1 = false, Argument2 = false
    c. Argument1 = true, Argument2 = true
    d. Argument1 = false, Argument2 = true
    */
    public void Exercise3Method4(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);
        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);

        /*
        a. When arg1= true and arg2 = false, the output results are:
            False, True, True, True
         
        b. When arg1 = false and arg2 = false, the output results are:
            False, False, False, False

        c. When arg1 = true and arg2 = true, the output results are:
            True, True, False, True
        
        d. When arg1 = false and arg2 = true, the output results are:
            False, True, True, True
         */ 
    }

} // end class
