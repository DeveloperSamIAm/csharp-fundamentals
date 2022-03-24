namespace MyFirstApplication;

public class Exercise1
{

    /*
    1. Write out a method with no arguments and a void return type that will
    print the output of the number 35 based on the number systems below.
    The values should be assigned to a variable inside the method prior to
    printing them using Console WriteLine. Utilize the conversion document
    from your resources.
    a. Decimal
    b. Hexadecimal
    c. Binary
    */
    public void Exercise1Method1()
    {
        int value1 = 35;
        int value2 = 0x23;
        int value3 = 0b0100011;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    /*
    2. Write a method that will accept 3 argument parameters and a void return
    type. The first argument should be of type byte. The second argument
    should be of type short. The third argument should be of type int. Using
    Implicit conversion, create variables to convert to using the below
    information. Use the argument parameters as the values to convert from.
    Print each converted variable using Console WriteLine.
    a. From byte to int
    b. From short to long
    c. From int to float
     */
    public void Exercise1Method2(byte alpha, short beta, int delta)
    {
        int MyByte = alpha;
        long MyShort = beta;
        float MyInt = delta;
        Console.WriteLine(MyByte);
        Console.WriteLine(MyShort);
        Console.WriteLine(MyInt);
    }

    /*
    3. Write a method that will accept 3 argument parameters and a void return
    type. The first argument should be of type double. The second argument
    should be of type float. The third argument should be of type long. Using
    Explicit conversion, create variables to convert to using the below
    information. Use the argument parameters as the values to convert from.
    Print each converted variable using Console WriteLine.
    a. From double to long
    b. From float to int
    c. From long to short
     */
    public void Exercise1Method3(double alpha, float beta, long delta)
    {
        double MyDouble = alpha;
        long MyLong = (long)MyDouble;

        float MyFloat = beta;
        int MyInt = (int)MyFloat;
        
        long OtherLong = delta;
        short OtherShort = (short)OtherLong;
        Console.WriteLine(MyLong);
        Console.WriteLine(MyInt);
        Console.WriteLine(OtherShort);
    }

    /*
    4. Write a method with no arguments and a void return type. Using the
    values below, assign them to a variable that best suits their value type.
    Utilize the digit separator when assigning them to your variables. Once you
    have defined your variables, print out each one using Console WriteLine. Do
    not use the same value type more than once.
    a. 123456.987 (double)
    b. -9516248 (int)
    c. 3500 (short)
    d. 988562486 (long)
    e. -19733.14895 (float)
     */
    public void Exercise1Method4()
    {
        double MyDouble = 123_456.987D;
        int MyInt = -9_516_248;
        short MyShort = 3_500;
        long MyLong = 988_562_486;
        float MyFloat = -19_733.14895F;
        Console.WriteLine(MyDouble);
        Console.WriteLine(MyInt);
        Console.WriteLine(MyShort);
        Console.WriteLine(MyLong);
        Console.WriteLine(MyFloat);
    }

} // end class


